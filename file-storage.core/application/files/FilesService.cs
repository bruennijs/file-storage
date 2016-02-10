using System;
using System.IO;
using log4net;

namespace FileStorage.application.services
{
    /// <summary>
    /// Application file service.
    /// </summary>
    public class FilesService {
      private static ILog Log = LogManager.GetLogger(typeof(FilesService));  
        
      public bool Create(string name) {
          
          Log.InfoFormat("FilesService.Create {0}", name);
          
          Console.WriteLine($"name is {name}");
          
          var path = Path.Combine(System.Reflection.Assembly.GetExecutingAssembly().Location, "test.txt");
          
          
          return true;          
      }
  }
}