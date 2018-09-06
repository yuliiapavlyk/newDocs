using System;
using Ninject.Modules;
using MyDocuments.BLL.Services;
using MyDocuments.BLL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyDocuments.PL.Dependencies
{
    public class DocumentBind:  NinjectModule
    {
        public override void Load()
        {
            Bind<IDocumentService>().To<DocumentService>();
        }
    }
}