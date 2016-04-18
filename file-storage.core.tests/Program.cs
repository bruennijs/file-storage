using Autofac;
using log4net;
using NUnitLite;
using filestorage.tests.common;

namespace filestorage.core.tests
{
    public class Program
    {
        private static ILog _log = log4net.LogManager.GetLogger(typeof(Program));

        public static void Main(string[] args)
        {
            //Console.WriteLine(Assembly.GetExecutingAssembly().CodeBase);

            log4net.Config.XmlConfigurator.Configure();
            _log.Info("test starting...");

            var builder = new ContainerBuilder();
            builder.RegisterModule(new Common.Ddd.AutoFacModule());
            builder.RegisterModule(new AutoFacModule());
            IntegrationTestBase.Container = builder.Build();

            new AutoRun().Execute(args);
        }
    }
}