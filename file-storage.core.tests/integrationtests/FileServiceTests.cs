using System;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using System.Threading.Tasks;
using Autofac;
using common.ddd.Infrastructure.Event;
using filestorage.core;
using filestorage.core.Event;
using NUnit.Framework;
using filestorage.tests.common;
using FileStorage.domain.files;

namespace FileStorage.core.tests.integrationtests
{
  [TestFixture]
  public class FileServiceTests : IntegrationTestBase
  {
      private IFilesApplicationService filesApplicationService;
      private IDomainEventBus domainEventBus;

      public FileServiceTests()
      {
          filesApplicationService = Container.Resolve<IFilesApplicationService>();
          domainEventBus = Container.Resolve<IDomainEventBus>();
      }

      [Test]
      [TestCase("meinkind")]
      public void When_FilesService_Create_expect_file_existing_on_disk(string name)
      {
          File file = filesApplicationService.Create(name);
          Assert.AreEqual(name, file.Name);
      }

      [Test]
      public void When_create_file_expect_created_event()
      {
          Task<FileCreatedEvent> observable = domainEventBus
              .Subscribe()
              .Take(1)
              .Timeout(TimeSpan.FromMilliseconds(100))
              .Select(e => e as FileCreatedEvent)
              .ToTask();	//// no repplaysubject in impl -> let task subscribe before sut fires

          File file = filesApplicationService.Create("neuedatei");

          observable.Wait();
          FileCreatedEvent fileCreatedEvent = observable.Result;
          Assert.IsNotNull(fileCreatedEvent);
          Assert.AreEqual(file.Id, fileCreatedEvent.File.Id);
      }
  }
}