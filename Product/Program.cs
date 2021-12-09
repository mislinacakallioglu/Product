using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Product1 = new Product();
            Product1.ProductBrand = "Twist";
            Product1.ProductName = "Mont";
            Product1.ProductSize = "L";
            Product1.ProductPrice = 1550;
            Product1.ProductDiscountPrice = 1550;

            Product Product2 = new Product();
            Product2.ProductBrand = "İpekyol";
            Product2.ProductName = "Kazak";
            Product2.ProductSize = "M";
            Product2.ProductPrice = 350;
            Product2.ProductDiscountPrice = 200;

            Product Product3 = new Product();
            Product3.ProductBrand = "U.S.POLO ASSN";
            Product3.ProductName = "Kot Pantolon";
            Product3.ProductSize = "L";
            Product3.ProductPrice = 180;
            Product3.ProductDiscountPrice = 150.99;

            Product Product4 = new Product();
            Product4.ProductBrand = "Mavi";
            Product4.ProductName = "Sweatshirt";
            Product4.ProductSize = "L";
            Product4.ProductPrice = 250;
            Product4.ProductDiscountPrice = 220.95;

            Product[] Products = new Product[] { Product1, Product2, Product3, Product4 };
            string[] Products1 = new string[] { "Twist", "İpekyol", "U.S. POLO ASSN", "Mavi" };

            for (int i = 0; i < Products1.Length; i++)
            {
                Console.WriteLine(Products1[i]);
            }

            foreach (var Product in Products)
            {
                Console.WriteLine(Product.ProductName + " : " + Product.ProductSize);
                Console.WriteLine(Product.ProductName + ":"+ Product.ProductPrice);
                
            }
            int j = 0;
            while (j < Products.Length)
            {
                Console.WriteLine(Products[j].ProductName +":"+ Products[j].ProductDiscountPrice);
                j++;

            }

        }
    }

    class Product
    {
        public string  ProductBrand { get; set; }
        public string ProductName{ get; set; }
        public string  ProductSize{ get; set; }
        public double ProductPrice{ get; set; }
        public double ProductDiscountPrice{ get; set; }
    }
}
