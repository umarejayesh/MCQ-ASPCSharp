using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using MyMVCApplication.Models;

namespace MyMVCApplication.Services
{
    public class StockService
    {
        public IList<Stock> GetLatest()
        {
            var stocks = new List<Stock>();

            //var document = XDocument.Load(HttpContext.Current.Server.MapPath("~/StockUpdates.xml"));

            //var root = document.Root;
            //if (root == null) throw new ArgumentNullException("Error in the xml document. No root element exists!");

            //var stockElements = root.Elements("Stock");

            //foreach (var stockElement in stockElements)
            //{
            //    var stock = new Stock()
            //    {
            //        Name = stockElement.Attribute("Name").Value,
            //        Price = Convert.ToDouble(stockElement.Attribute("Price").Value),
            //        LastPrice = Convert.ToDouble(stockElement.Attribute("LastPrice").Value)
            //    };

            //    stocks.Add(stock);
            //}

            return stocks; 

        }
    }
}
