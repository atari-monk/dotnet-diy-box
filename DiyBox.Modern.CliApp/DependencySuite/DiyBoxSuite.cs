using CommandDotNet.Unity.Helper;
using DiyBox.Core;
using Unity;

namespace DiyBox.Modern.CliApp;

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