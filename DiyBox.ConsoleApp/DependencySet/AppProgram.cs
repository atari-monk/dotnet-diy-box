using DIHelper;
using DiyBox.Core;
using Unity;
using Unity.Injection;

namespace DiyBox.ConsoleApp;

public class AppProgram<TProgram> 
    : CLIFramework.AppProgram<TProgram>
    where TProgram : IAppProgram
{
    public AppProgram(
        IUnityContainer container) 
        : base(container)
    {
    }

    protected override InjectionConstructor GetInjectionConstructor()
    {
        return new InjectionConstructor(
            Container.Resolve<IDiyBoxWizard>(
                nameof(DiyBoxWizard)));
    }
}