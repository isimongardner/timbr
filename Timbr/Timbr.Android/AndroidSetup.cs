using Autofac;
using Timbr.Interfaces;

namespace Timbr.Droid
{
    public class AndroidSetup : ApplicationSetup
    {
        public override void RegisterDependecies()
        {
            base.RegisterDependecies();
            base._containerBuilder.RegisterType<FileHelper>().As<IFileHelper>();
        }
    }
}