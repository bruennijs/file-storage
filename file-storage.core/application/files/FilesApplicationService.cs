using System;
using System.IO;
using System.Reflection;
using FileStorage.domain.files;
using log4net;
using common.ddd.Domain.Entity;

namespace filestorage.core.application
{
    /// <summary>
    /// Application file service.
    /// </summary>
    public class FilesApplicationService : IFilesApplicationService {
      private static ILog Log = LogManager.GetLogger(typeof(FilesApplicationService));

      public bool Create(string name)
      {

        var file = new FileStorage.domain.files.File(new Id("4711"), "meineDatei.txt");

        Log.InfoFormat("FilesService.Create {0}", name);
          
        Console.WriteLine($"name is {name}");
          
          var path = Path.Combine(Assembly.GetEntryAssembly().Location, "test.txt");         

          return true;
      }
  }
}