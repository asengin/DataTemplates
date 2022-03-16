using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTemplates
{
    public enum ProductType
    {
        Food,
        Appliances
    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImagePath { get; set; }
        public ProductType ProductType { get; set; }
    }
}
