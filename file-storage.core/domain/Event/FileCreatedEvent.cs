using Common.Ddd.Infrastructure.Event.Implementation;
using FileStorage.domain.files;

namespace filestorage.core.Event
{
  public class FileCreatedEvent : DomainEvent
  {
    public File File;

    public FileCreatedEvent(File file)
    {
      File = file;
    }
  }
}
