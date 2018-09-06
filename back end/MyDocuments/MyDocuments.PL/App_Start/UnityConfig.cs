using System.Web.Http;
using Unity;
using Unity.Injection;
using Unity.WebApi;
using MyDocuments.BLL.Interfaces;
using MyDocuments.BLL.Services;
using MyDocuments.DAL.Entities  ;
using MyDocuments.DAL.Repositories;
using MyDocuments.DAL.Repositories.Interfaces;

namespace MyDocuments.PL
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<IDocumentService, DocumentService>();
            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IUnitOfWork, UnitOfWork>(new InjectionConstructor("LearnWithMentor_DBEntities"));
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}