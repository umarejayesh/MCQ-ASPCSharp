using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMVCApplication.Validations
{
    [AttributeUsage(AttributeTargets.Property)] 
    public class Age : ValidationAttribute 
    {
        private DateTime _dateOfBirth; 

        public override bool IsValid(object value)
        {
            _dateOfBirth = (DateTime) value;

           var tb = DateTime.Now.Subtract(_dateOfBirth);   
            
            if((tb.TotalDays / 365) > 18)
                return true;

            return false; 
        }
    }
}
