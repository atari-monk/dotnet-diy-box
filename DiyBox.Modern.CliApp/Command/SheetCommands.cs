using CommandDotNet;
using DiyBox.CommandDotNet;
using DiyBox.Core;

namespace Modern.CLI.App.Template;

[Command("sheet")]
public class SheetCommands
{
    private readonly IDiyBoxWizard diyBoxWizard;

    public SheetCommands(
        IDiyBoxWizard diyBoxWizard)
    {
        this.diyBoxWizard = diyBoxWizard;
    }

    [DefaultCommand()]
    public void RunBoxWizard(SizeArg model)
    {
        diyBoxWizard.RunWizard(GetArgs(model));
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