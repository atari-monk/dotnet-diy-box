using DIHelper;
using DiyBox.Core;

namespace DiyBox.ConsoleApp;

public class DiyBoxProgram 
	: IMainProgram
{
    private readonly IDiyBoxWizard diyBoxWizard;

    public DiyBoxProgram(
		IDiyBoxWizard diyBoxWizard)
	{
        this.diyBoxWizard = diyBoxWizard;
    }
	
	public int Main(string[] args)
	{
		diyBoxWizard.RunWizard(args);
		return 0;
	}
}