using Autofac;
using Timbr.Data;
using Timbr.Services;
using Timbr.Views;

namespace Timbr
{
    public class ApplicationSetup
    {
        protected readonly ContainerBuilder _containerBuilder;

        public ApplicationSetup()
        {
            _containerBuilder = new ContainerBuilder();
        }

        public IContainer InitializeContainer()
        {
            RegisterDependecies();
            return _containerBuilder.Build();
        }

        public virtual void RegisterDependecies()
        {
            _containerBuilder.RegisterType<MainPage>();
            _containerBuilder.RegisterType<CreateProjectPage>();
            _containerBuilder.RegisterType<CreateTaskPage>();
            _containerBuilder.RegisterType<CreateProjectView>();
            _containerBuilder.RegisterType<CreateTaskView>();
            _containerBuilder.RegisterType<MainView>();
            _containerBuilder.RegisterType<ProjectService>().As<IProjectService>();
            _containerBuilder.RegisterType<Database>().As<IDatabase>();
        }
    }
}