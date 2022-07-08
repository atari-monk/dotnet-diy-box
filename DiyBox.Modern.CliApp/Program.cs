using Config.Wrapper;
using DIHelper;
using DiyBox.Modern.CliApp;
using Unity;

var unity = new UnityContainer()
    .AddExtension(
        new Diagnostic());

var libsFilter = new SuiteFilter(isComponentSuite: true);
var appFilter = new SuiteFilter(isComponentSuite: false, isAppSuite: true);

var suites = new Dictionary<SuiteFilter, IDependencySuite>
{
    {
        libsFilter
        , new LibSuite(unity)
    }
};

IMultiBootstraper booter = new MultiBootstraper(suites);
booter.SetupLibs(libsFilter);
AddSuitesBasedOnConfig(unity, suites);
booter.SetupApp(appFilter);
booter.RunApp(args);

void AddSuitesBasedOnConfig(
    IUnityContainer unity
    , Dictionary<SuiteFilter, IDependencySuite> suites)
{
    var config = unity.Resolve<IConfigReader>();
    var diyBoxSettings = config.GetConfigSection<DiyBoxSettings>(nameof(DiyBoxSettings));
    if (diyBoxSettings == null || diyBoxSettings.EvenFolds)
    {
        suites.Add(
            appFilter
            , new EvenFoldsBoxSuite(unity));
    }
    else
    {
        suites.Add(
            appFilter
            , new WasteInFoldsBoxSuite(unity));
    }
}