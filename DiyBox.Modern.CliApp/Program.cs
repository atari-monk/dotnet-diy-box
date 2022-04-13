using DIHelper;
using Modern.CLI.App.Template;
using Unity;

IBootstraper booter = new Bootstraper(
    new UnityDependencySuite(
        new UnityContainer().AddExtension(new Diagnostic())));
booter.Boot(args);