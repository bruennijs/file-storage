using System;
using System.Reflection;
using log4net;
using NUnitLite;

namespace Redis.test
{
  public class Program
  {
    private static ILog _log = log4net.LogManager.GetLogger(typeof(Program));

    public static void Main(string[] args)
    {
      //Console.WriteLine(Assembly.GetExecutingAssembly().CodeBase);

      log4net.Config.XmlConfigurator.Configure();
      _log.Info("test starting...");

      new AutoRun().Execute(args);
    }
  }
}