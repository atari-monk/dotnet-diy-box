using DiyBox.CommandDotNet;
using DiyBox.Core;

namespace DiyBox.Modern.CliApp;

public abstract class DiyBoxCommands
{
    private readonly IDictionary<Wizards, IDiyBoxWizard> wizards;

    protected DiyBoxCommands(
        IDictionary<Wizards, IDiyBoxWizard> wizards)
    {
        this.wizards = wizards;
    }

    protected IDiyBoxWizard GetWizard(Wizards wiz)
    {
        return wizards[wiz];
    }

    protected string[] GetArgs(Size3dArg model)
    {
        return new string[] 
        {
            model.Length.ToString()
            , model.Height.ToString()
            , model.Depth.ToString()
        };
    }

    protected string[] GetArgs(Size2dArg model)
    {
        return new string[] 
        {
            model.Length.ToString()
            , model.Height.ToString()
        };
    }
}