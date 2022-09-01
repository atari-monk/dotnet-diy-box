using DIHelper.Unity;
using Unity;

namespace DiyBox.Modern.CliApp;

public class AppCommandSet
    : UnityDependencySet
{
    public AppCommandSet(
        IUnityContainer container) 
        : base(container)
    {
    }

    public override void Register()
    {
        Container.RegisterSingleton<BoxCommands>();
        Container.RegisterSingleton<SheetCommands>();
    }
}