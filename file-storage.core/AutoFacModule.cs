using Autofac;
using filestorage.core.application;
using FileStorage.domain.identity;

public class AutoFacModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        //string t;
        
        builder.RegisterType<IIdentityService>()
            .As<IIdentityService>()
            .InstancePerLifetimeScope();
            
        builder.RegisterType<FilesService>().SingleInstance();         

        // builder.Register(c => new ValuesService(c.Resolve<ILogger>()))
        //     .As<IValuesService>()
        //     .InstancePerLifetimeScope();
    }
}