using DiyBox.Core;
using Unity;

namespace DiyBox.Modern.CliApp;

public class EvenFoldsBoxSuite
    : DiyBoxSuite
{
    public EvenFoldsBoxSuite(
        IUnityContainer container) 
        : base(container) 
    {
    }

    protected override void RegisterBoxComputer()
    {
        RegisterSet<DiyBoxWithEvenFoldsSet>();
    }
}