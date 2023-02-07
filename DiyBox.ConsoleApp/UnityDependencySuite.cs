using CLIHelper.Unity;
using Config.Wrapper.Unity;
using DiyBox.Core;
using Serilog.Wrapper.Unity;
using Unity;

namespace DiyBox.ConsoleApp;

public class UnityDependencySuite 
	: DIHelper.Unity.UnityDependencySuite
{
	public UnityDependencySuite(
		IUnityContainer container) :
			base(container)
	{
	}
	
	protected override void RegisterAppData()
    {
        RegisterSet<SerilogSet>();
        RegisterSet<AppConfigSet>();
        RegisterSet<CliIOSet>();
        RegisterSet<DiyBoxWithEvenFoldsSet>();
        RegisterSet<DescriptorSet>();
        RegisterSet<DescriptorDictionarySet>();
        RegisterSet<WizardSet>();
        RegisterSet<WizardDictionarySet>();
    }

	protected override void RegisterProgram() => 
		RegisterSet<CLIFramework.AppProgram<DiyBoxProgram>>();
}