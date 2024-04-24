using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MyMVCApplication.Models
{
    public class Category
    {
        public string Name { get; set;  }

        private IList<Product> _products = new List<Product>();

        public IList<Product> Products
        {
            get { return _products;  }
            set { _products = value; }
        }
    }
}
