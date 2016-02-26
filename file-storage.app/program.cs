using System;
using log4net;
using filestorage.core.application;

namespace filestorage.core
{
    public class Program {
        public static void Main(string[] args) {
            
            //log4net.
            
            string var1 = "sugaaaar";
            var fs = new FilesService();
            fs.Create(var1);
            Console.WriteLine($"Can you give me {var1}");
        }   
    }
}