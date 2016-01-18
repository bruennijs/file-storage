using Microsoft.AspNet.Mvc;
using Newtonsoft.Json.Linq;

namespace file_storage.Controllers
{
  [Route("api/files")]
  public class FilesController
  {
    [HttpPost("")]
    public void Post()
    {
        //var body = JObject.Parse("");
        System.Console.WriteLine("test");
    }
    
    [HttpPost("{id}")]
    public void Post(string newId)
    {
      System.Console.WriteLine($"new id[{newId}]");
    }
  }   
}