using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using MyMVCApplication.Models;

namespace MyMVCApplication.Controllers
{
    public class CategoryController : Controller  
    {
        public ActionResult New()
        {
            return View(); 
        }
      
        public void AddProduct()
        {
            
        }

        public void Create(Category category)
        {

        }

       
        public ActionResult List()
        {
            var categories = new List<Category>()
                                 {
                                     new Category() {Name = "Beverages"},
                                     new Category() {Name = "Condiments"},
                                     new Category() {Name = "Meat"}
                                 };

            ViewData.Model = categories; 

            return View(); 
        }
       
        
        public ActionResult PartialList()
        {
            var categories = new List<Category>()
                                 {
                                     new Category() {Name = "Beverages"},
                                     new Category() {Name = "Condiments"},
                                     new Category() {Name = "Meat"}
                                 };

            ViewData.Model = categories; 


            return View("Categories"); 
        }
        
        public ActionResult ListPartial()
        {
            return View("Categories"); 
        }
       
    }
}
