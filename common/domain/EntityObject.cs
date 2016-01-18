public class EntityObject
{
  public EntityObject(string id)
  {
        if (id == null)
            throw new System.ArgumentNullException("id");
        this.Id = id;
  }
  
  public string Id { get; private set; }
}