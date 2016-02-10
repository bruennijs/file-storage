using Autofac;
using FileStorage.application.services;
using FileStorage.domain.identity;

public class AutoFacModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<IIdentityService>()
            .As<IIdentityService>()
            .InstancePerLifetimeScope();
            
        builder.RegisterType<FilesService>().InstancePerLifetimeScope();            

        // builder.Register(c => new ValuesService(c.Resolve<ILogger>()))
        //     .As<IValuesService>()
        //     .InstancePerLifetimeScope();
    }
}