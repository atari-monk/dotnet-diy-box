using DiyBox.Core;
using Unity;

namespace DiyBox.Modern.CliApp;

public class WasteInFoldsBoxSuite
    : DiyBoxSuite
{
    public WasteInFoldsBoxSuite(
        IUnityContainer container) 
        : base(container) 
    {
    }

    protected override void RegisterBoxComputer()
    {
        RegisterSet<DiyBoxWithWasteInFoldsSet>();
    }
}