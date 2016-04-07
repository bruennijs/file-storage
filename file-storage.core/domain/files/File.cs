using common.ddd.Domain.Entity;

namespace FileStorage.domain.files
{
  public class File
  {    
      public Id Id { get; private set; }

      // Gets or sets the file name
      public string Name { get; private set;}

    public File(Id id, string name)
    {
      Id = id;
      Name = name;
    }
  } 
}