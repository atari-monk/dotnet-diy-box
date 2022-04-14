using CommandDotNet;
using DiyBox.CommandDotNet;
using DiyBox.Core;

namespace Modern.CLI.App.Template;

[Command("box")]
public class BoxCommands
{
    private readonly IDiyBoxWizard diyBoxWizard;

    public BoxCommands(
        IDiyBoxWizard diyBoxWizard)
    {
        this.diyBoxWizard = diyBoxWizard;
    }

    [DefaultCommand()]
    public void RunBoxWizard(SizeArg model)
    {
        diyBoxWizard.RunWizard(
            GetArgs(model));
    }

    private string[] GetArgs(SizeArg model)
    {
        return new string[] 
        {
            model.Length.ToString()
            , model.Width.ToString()
            , model.Height.ToString()
        };
    }
}