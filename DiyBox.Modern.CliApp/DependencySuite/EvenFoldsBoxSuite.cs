using DiyBox.Core;
using Unity;

namespace DiyBox.Modern.CliApp;

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