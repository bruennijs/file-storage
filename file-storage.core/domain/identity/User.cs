using Common.Ddd.Infrastructure.Persistence;

namespace  FileStorage.domain.identity
{
/// <summary>
/// User in file domain.
/// </summary>
public class User : Entity {
  
  public User(Id id, string name)
    :base(id)
  {
    this.Name = name;
  }
  
  /// <summary>
  /// Name of the user
  /// </summary>
  /// <returns></returns>
  public string Name { get; set; }
}  
}
