using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBucksApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductType { get; set; }
        public string ProductName { get; set; }
        public string ProductImgUrl { get; set; }
        public Color ProductImgBackground { get; set; }
        public string ProductDescription { get; set; }
        public double ProductBasePrice { get; set; }
        public double ProductPrice { get; set; }
        public bool ProductIsFav { get; set; }
        public string ProductSizeType;
    }
}
