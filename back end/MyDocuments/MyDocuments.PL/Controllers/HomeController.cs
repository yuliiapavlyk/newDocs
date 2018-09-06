using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyDocuments.BLL.Infrastructure;
using MyDocuments.BLL.Interfaces;
using MyDocuments.BLL.DTO;

namespace MyDocuments.PL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            var users = documentService.GetAllDocuments();
            return View();
        }
        IDocumentService documentService;
        public HomeController(IDocumentService serv)
        {
            this.documentService = serv;
        }
        
    }
}
