using CommandDotNet;
using DiyBox.CommandDotNet;
using DiyBox.Core;

namespace DiyBox.Modern.CliApp;

[Command("box")]
public class BoxCommands
    : DiyBoxCommands
{
    public BoxCommands(
        IDictionary<Wizards, IDiyBoxWizard> wizards)
        : base(wizards)
    {
    }

    [DefaultCommand()]
    public void RunBoxWizard(SizeArg model)
    {
        GetWizard(Wizards.DiyBoxWizard)
            .RunWizard(
                GetArgs(model));
    }
}