using System.IO;
using System.Reflection;
using log4net;
using Common.Ddd.Infrastructure.Event;
using Common.Ddd.Infrastructure.Persistence;
using filestorage.core.Event;
using File = FileStorage.domain.files.File;

namespace filestorage.core.application
{
    /// <summary>
    /// Application file service.
    /// </summary>
    public class FilesApplicationService : IFilesApplicationService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(FilesApplicationService));
        private readonly IDomainEventBus _domainEventBus;

        public FilesApplicationService(IDomainEventBus domainEventBus)
        {
            _domainEventBus = domainEventBus;
        }

        public File Create(string name)
        {
            var file = new File(new Id("4711"), name);

            Log.InfoFormat("FilesService.Create {0}", name);

            var path = Path.Combine(Assembly.GetEntryAssembly().Location, "test.txt");

            _domainEventBus.Publish(new FileCreatedEvent(file));

            return file;
        }
    }
}