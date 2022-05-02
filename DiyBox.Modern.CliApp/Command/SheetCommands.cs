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
    public void ComputeSheetSize(SizeArg model)
    {
        GetWizard(Wizards.SheetWizard)
            .RunWizard(
                GetArgs(model));
    }

    [Command("print")]
    public void PrintInstructions(SizeArg model)
    {
        GetWizard(Wizards.PrintOnSheet)
            .RunWizard(
                GetArgs(model));
    }
}