using FileStorage.domain.files;

namespace filestorage.core
{
  public interface IFilesApplicationService
  {
    File Create(string name);
  }
}