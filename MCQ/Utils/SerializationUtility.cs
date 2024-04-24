﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace MyMVCApplication.Utils
{
    public class SerializationUtility
    {
        public static string Serialize(object obj)
        {
            var sw = new StringWriter(new StringBuilder()); 
            var formatter = new LosFormatter();
            formatter.Serialize(sw, obj);
            return sw.ToString(); 
        }

        public static object Deserialize(string data)
        {
            if (data == null)
                return null;
            return (new LosFormatter()).Deserialize(data);
        }
    }
}
