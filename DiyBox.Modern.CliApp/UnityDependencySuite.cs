using CLIHelper.Unity;
using CommandDotNet.Unity.Helper;
using Config.Wrapper.Unity;
using DiyBox.Core;
using Serilog.Wrapper.Unity;
using Unity;

namespace Modern.CLI.App.Template;

public class UnityDependencySuite 
    : DIHelper.Unity.UnityDependencySuite
{
    public UnityDependencySuite(
        IUnityContainer container) 
        : base(container) 
    {
    }

    protected override void RegisterAppData()
    {
        RegisterSet<AppLoggerSet>();
        RegisterSet<AppConfigSet>();
        RegisterSet<DiyBoxSet>();
        RegisterSet<DescriptorSet>();
        RegisterSet<CliIOSet>();
    }
    
    protected override void RegisterCommands() => 
        RegisterSet<AppCommandSet>();

    protected override void RegisterProgram() => 
        RegisterSet<AppProgSet<AppProg>>();
}