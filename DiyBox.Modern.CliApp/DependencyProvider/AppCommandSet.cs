using DIHelper.Unity;
using DiyBox.Core;
using Unity;
using Unity.Injection;

namespace Modern.CLI.App.Template;

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
        Container.RegisterSingleton<BoxCommands>(
            new InjectionConstructor(
                Container.Resolve<IDiyBoxWizard>(nameof(DiyBoxWizard))));
        Container.RegisterSingleton<SheetCommands>(
            new InjectionConstructor(
                Container.Resolve<IDiyBoxWizard>(nameof(SheetWizard))));
    }
}