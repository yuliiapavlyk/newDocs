using System;
using Ninject.Modules;
using System.Collections.Generic;
using System.Linq;
using MyDocuments.DAL.Repositories;
using MyDocuments.DAL.Repositories.Interfaces;
using System.Threading.Tasks;

namespace MyDocuments.BLL.Infrastructure
{
    public class ServiceModuleNinject:NinjectModule 
    {
        private string connectionString;

        public ServiceModuleNinject(string connection)
        {
            connectionString = connection;
        }
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}
