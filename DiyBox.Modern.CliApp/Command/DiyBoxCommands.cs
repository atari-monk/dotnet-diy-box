using DiyBox.CommandDotNet;
using DiyBox.Core;

namespace Modern.CLI.App.Template;

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

    protected string[] GetArgs(SizeArg model)
    {
        return new string[] 
        {
            model.Length.ToString()
            , model.Height.ToString()
            , model.Depth.ToString()
        };
    }
}
