using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using BusinessObjects.Entities;
using BusinessObjects.Utils;
using MyMVCApplication.CustomFilters;

namespace MyMVCApplication.Controllers
{
    public class RegisterController : Controller
    {
        private Customer _customer; 

        public ActionResult Index()
        {
            return View(); 
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            _customer = (SerializationUtility.Deserialize(Request.Form["Customer"]) ?? TempData["Customer"]
                                                                                       ?? new Customer()) as Customer;
            TryUpdateModel(_customer); 
        }

        protected override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            if(filterContext.Result is RedirectToRouteResult)
                TempData["Customer"] = _customer; 
        }
        
       public ActionResult BasicDetails(string nextButton)
       {
           if(nextButton != null)
           {
               return RedirectToAction("AddressDetails"); 
           }
           return View(); 
        }

        [Captcha]
        public ActionResult Register(string captchaName,bool isValid)
        {
            if (isValid)
                return View("Confirm");
            else return View("Index"); 
        }
        
        public ActionResult AddressDetails(string nextButton, string backButton)
        {
            if(nextButton != null)
            {
                return RedirectToAction("Confirm"); 
            }

            if(backButton != null)
            {
                return RedirectToAction("BasicDetails"); 
            }

            return View(); 
        }

        public ActionResult Exam()
        {
            return View(); 
        }

        public ActionResult Confirm()
        {
            return View(); 
        }

        public ActionResult DemoGrid()
        {
            var customers = new List<Customer>()
                                {
                                    new Customer() {FirstName = "Mohammad", LastName = "Azam"},
                                    new Customer() {FirstName = "John", LastName = "Doe"}, 
                                    new Customer() {FirstName = "Mary", LastName ="Kate"} 
                                };

            ViewData["Customers"] = customers; 
            return View(); 
        }


    }
}
