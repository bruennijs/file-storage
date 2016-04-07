using Autofac;
using Autofac.Core;
using filestorage.core;
using NUnit.Framework;
using filestorage.tests.common;

namespace FileStorage.core.tests.integrationtests
{
  [TestFixture]
  public class FileServiceTests : IntegrationTestBase
  {
    private IFilesApplicationService filesApplicationService;

    public FileServiceTests()
    {
      filesApplicationService = Container.Resolve<IFilesApplicationService>();
    }

    [Test]
    [TestCase("meinkind")]
    public void When_FilesService_Create_expect_file_existing_on_disk(string name)
    {
      //Container.Resolve<IFileService>();
      Assert.True(filesApplicationService.Create(name));
    }
  }
}