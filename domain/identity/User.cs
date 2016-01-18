namespace  FileStorage.domain.identity
{
/// <summary>
/// User in file domain.
/// </summary>
public class User : EntityObject {
  
  public User(string id, string name)
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
