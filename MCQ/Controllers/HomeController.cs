using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessObjects;
using BusinessObjects.Repositories;
using MyMVCApplication.Models;
using MyMVCApplication.Services;
using StructureMap;

namespace MyMVCApplication.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        private StockService _stockService = null;
        private ImageService _imageService = null; 

        public HomeController()
        {
            _stockService = new StockService();
            _imageService = new ImageService();
        }

        public ActionResult Index()
        {
            return View(); 
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Exam()
        {
            return View(); 
        }
        
        public ActionResult ListRoles()
        {
            var r = ObjectFactory.GetInstance<IRoleRepository>();
            var roles = r.GetAll();

            var u = ObjectFactory.GetInstance<UserRepository>();
            u.GetAll(); 

            return View(); 
        }

        public ActionResult ListRoles2()
        {
            //var repostory = new RoleRepository(new ObjectContextPerRequest());
            //var roles = repostory.GetAll(); 

            

            return View("Index"); 
        }

    }
}
