using DiyBox.Core;
using Unity;

namespace Modern.CLI.App.Template;

public class EvenFoldsBoxSuite
    : DIHelper.Unity.UnityDependencySuite
{
    public EvenFoldsBoxSuite(
        IUnityContainer container) 
        : base(container) 
    {
    }

    protected virtual void RegisterBoxComputer()
    {
        RegisterSet<DiyBoxWithEvenFoldsSet>();
    }
}