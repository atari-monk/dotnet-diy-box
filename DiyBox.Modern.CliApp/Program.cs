using Config.Wrapper;
using DIHelper;
using DiyBox.Modern.CliApp;
using Unity;

var unity = new UnityContainer()
    .AddExtension(
        new Diagnostic());

var suites = new Dictionary<SuiteFilter, IDependencySuite>
{
    { 
        new SuiteFilter(
            isComponentSuite: true
            , isAppSuite: false)
        , new LibSuite(unity)
    }
};

IMultiBootstraper booter = new MultiBootstraper(suites);
booter.CreateApp(new SuiteFilter(true));

var config = unity.Resolve<IConfigReader>();
var diyBoxSettings = config.GetConfigSection<DiyBoxSettings>(nameof(DiyBoxSettings));
if(diyBoxSettings == null || diyBoxSettings.EvenFolds)
{
    suites.Add(
        new SuiteFilter(
            isComponentSuite: false
            , isAppSuite: true)
        , new EvenFoldsBoxSuite(unity));
}
else
{
    suites.Add(
        new SuiteFilter(
            isComponentSuite: false
            , isAppSuite: true)
        , new WasteInFoldsBoxSuite(unity));
}

booter.RunApp(args);