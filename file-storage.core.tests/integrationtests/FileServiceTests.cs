using Autofac.Core;
using NUnit.Framework;
using filestorage.tests.common;

namespace FileStorage.core.tests.integrationtests
{
  [TestFixture]
  public class FileServiceTests : IntegrationTestBase
  {
    [Test]
    public void When_FilesService_Create_expect_file_existing_on_disk()
    {
      //Container.Resolve<IFileService>();
    }
  }
}