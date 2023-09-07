using StarBucksApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBucksApp.Services
{
    public class ProductService
    {
        private static ProductService instance;

        public static ProductService Instance
        {
            get
            {
                instance = instance ?? new ProductService();
                return instance;
            }
        }

        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product()
                {
                    ProductId=1010,
                    ProductType="Coffee",
                    ProductName="Chocolate Frappuccino",
                    ProductImgUrl="chocolate_frappuccino.png",
                    ProductImgBackground=Color.FromHex("#F3F1ED"),
                    ProductIsFav=true,
                    ProductPrice=20.00,
                    ProductBasePrice=20.00,
                    ProductSizeType="Tall",
                    ProductDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam at mi vitae augue feugiat scelerisque in a eros."
                },
                new Product()
                {
                    ProductId=1011,
                    ProductType="Tea",
                    ProductName="Tea Frappuccino",
                    ProductImgUrl="tea_frappuccino.png",
                    ProductImgBackground= Color.FromHex("#F5F9E0"),
                    ProductIsFav=false,
                    ProductPrice=30.00,
                    ProductBasePrice=30.00,
                    ProductSizeType="Tall",
                    ProductDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam at mi vitae augue feugiat scelerisque in a eros."
                }
            };
        }
    }
}
