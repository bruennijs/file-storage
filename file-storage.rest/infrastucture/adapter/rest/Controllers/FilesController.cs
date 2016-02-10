using System;
using FileStorage.application.services;
using FileStorage.domain.identity;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;

namespace file_storage.Controllers
{
    [Route("api/files")]
  public class FilesController : Controller
  {
    IIdentityService identityService;
    FilesService filesService;

    public FilesController(IIdentityService identityService, FilesService fileService)
    {
      Console.WriteLine("filesController ctor");
      this.identityService = identityService;
      this.filesService = fileService;  
    }
    
    [HttpPost()]
    public void Post()
    {
        //var body = JObject.Parse(request.Body);
        System.Console.WriteLine("test");
    }
    
    [HttpPost("{id}")]
    public void Post(string newId)
    {
      System.Console.WriteLine($"new id[{newId}]");
    }
  }   
}