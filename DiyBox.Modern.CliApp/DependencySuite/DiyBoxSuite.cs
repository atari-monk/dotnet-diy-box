using CLIHelper.Unity;
using CommandDotNet.Unity.Helper;
using Config.Wrapper.Unity;
using DiyBox.Core;
using Serilog.Wrapper.Unity;
using Unity;

namespace Modern.CLI.App.Template;

public abstract class DiyBoxSuite
    : DIHelper.Unity.UnityDependencySuite
{
    public DiyBoxSuite(
        IUnityContainer container) 
        : base(container) 
    {
    }

    protected override void RegisterAppData()
    {
        RegisterSet<AppLoggerSet>();
        RegisterSet<AppConfigSet>();
        RegisterSet<CliIOSet>();
        RegisterBoxComputer();
        RegisterSet<DescriptorSet>();
        RegisterSet<DescriptorDictionarySet>();
        RegisterSet<WizardSet>();
        RegisterSet<WizardDictionarySet>();
    }

    protected abstract void RegisterBoxComputer();

    protected override void RegisterCommands() => 
        RegisterSet<AppCommandSet>();

    protected override void RegisterProgram() => 
        RegisterSet<AppProgSet<AppProg>>();
}
