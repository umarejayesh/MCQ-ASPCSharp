using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using MyMVCApplication.Services;

namespace MyMVCApplication
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class CaptchaImageHandler : IHttpHandler
    {
        private CaptchaService _service; 

        public CaptchaImageHandler()
        {
            _service = new CaptchaService();
        }

        public void ProcessRequest(HttpContext context)
        {
           _service.CreateImage(context); 
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
