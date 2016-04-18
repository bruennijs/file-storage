using common.ddd;

namespace FileStorage.domain.files
{
  public class File : Entity
  {
    // Gets or sets the file name
    public string Name { get; private set;}

    public File(Id id, string name)
      :base(id)
    {
      Name = name;
    }
  } 
}