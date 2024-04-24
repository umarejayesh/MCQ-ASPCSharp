using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVCApplication.Services;

namespace MyMVCApplication.CustomFilters
{
    public class CaptchaAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string p = HttpContext.Current.Request.Form["captcha"].ToString();

            string generatedCaptchaText = HttpContext.Current.Cache.Get("cachedCaptcha") as String; 

            if(String.IsNullOrEmpty(generatedCaptchaText))
                return; 

            if(p.ToUpperInvariant().Equals(generatedCaptchaText.ToUpperInvariant()))
            {
                filterContext.ActionParameters["isValid"] = true; 
            }
            else
            {
                filterContext.ActionParameters["isValid"] = false; 
                // remove the cache 
                HttpContext.Current.Cache.Remove("cachedCaptcha"); 
            }

            base.OnActionExecuting(filterContext);
        }
    }
}
