using CommandDotNet;
using DiyBox.CommandDotNet;
using DiyBox.Core;

namespace DiyBox.Modern.CliApp;

[Command("sheet")]
public class SheetCommands
    : DiyBoxCommands
{
     public SheetCommands(
        IDictionary<Wizards, IDiyBoxWizard> wizards)
        : base(wizards)
    {
    }

    [DefaultCommand()]
    public void RunBoxToSheetWizardCmd(Size3dArg model)
    {
        GetWizard(Wizards.BoxToSheetWizard)
            .RunWizard(
                GetArgs(model));
    }

    [Command("print")]
    public void RunPrintBoxOnSheetCmd(Size3dArg model)
    {
        GetWizard(Wizards.PrintBoxOnSheet)
            .RunWizard(
                GetArgs(model));
    }

    [Command("tobox")]
    public void RunSheetToBoxWizardCmd(Size2dArg model)
    {
        GetWizard(Wizards.SheetToBoxWizard)
            .RunWizard(
                GetArgs(model));
    }
}