using CLIHelper.Unity;
using Config.Wrapper.Unity;
using Serilog.Wrapper.Unity;
using Unity;

namespace DiyBox.Modern.CliApp;

public class LibSuite
    : DIHelper.Unity.UnityDependencySuite
{
    public LibSuite(
        IUnityContainer container) 
        : base(container) 
    {
    }

    protected override void RegisterAppData()
    {
        RegisterSet<SerilogSet>();
        RegisterSet<AppConfigSet>();
        RegisterSet<CliIOSet>();
    }
}