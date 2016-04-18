using Autofac;
using common.ddd.Infrastructure.Event;
using common.ddd.Infrastructure.Event.Implementation;

namespace common.ddd
{
  public class AutoFacModule : Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      builder.RegisterType<DomainEventBus>().As<IDomainEventBus>().SingleInstance();
    }
  }
}