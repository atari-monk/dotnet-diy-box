using DiyBox.Core;
using Unity;

namespace DiyBox.Modern.CliApp;

public class WasteInFoldsBoxSuite
    : DIHelper.Unity.UnityDependencySuite
{
    public WasteInFoldsBoxSuite(
        IUnityContainer container) 
        : base(container) 
    {
    }

    protected virtual void RegisterBoxComputer()
    {
        RegisterSet<DiyBoxWithWasteInFoldsSet>();
    }
}