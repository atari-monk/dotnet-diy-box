using DIHelper;
using DiyBox.Modern.CliApp;
using Unity;

IBootstraper booter = new Bootstraper(
    new EvenFoldsBoxSuite(
        new UnityContainer().AddExtension(new Diagnostic())));
booter.Boot(args);