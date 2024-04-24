using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using MyMVCApplication.Models;

namespace MyMVCApplication.Services
{
    public class ImageService
    {
        public IList<SlideImage> GetAll()
        {
            var slides = new List<SlideImage>(); 

            // read the images from the directory 

            var images = Directory.GetFiles(HttpContext.Current.Server.MapPath("~/Images")); 
            
            foreach(var image in images)
            {
                var slide = new SlideImage()
                             {
                                 Url = "/Images/" + System.IO.Path.GetFileName(image),
                                 Caption = System.IO.Path.GetFileNameWithoutExtension(image)
                             }; 

                slides.Add(slide);
            }

            return slides; 
        }

    }
}
