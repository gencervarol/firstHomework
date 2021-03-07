using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
          
        {

            Product product1 = new Product();
            product1.productBrand = "Adidas";
            product1.productId = 1907;
            product1.productName = "Yeni Sezon Çubuklu Forma";
            product1.productPrice = 239;
            product1.productRange = "Kit";

            Product product2 = new Product();
            product2.productBrand = "Fenerium";
            product2.productId = 1001;
            product2.productName = "Yaşa Fenerbahçe Şal Atkı";
            product2.productPrice = 25;
            product2.productRange = "Scarf";

            Product product3 = new Product();
            product3.productBrand = "Fenerium";
            product3.productId = 1453;
            product3.productName = "This is İstanbul";
            product3.productPrice = 49;
            product3.productRange = "T-shirt";

            Product product4 = new Product();
            product4.productBrand = "Kinetix";
            product4.productId = 6448;
            product4.productName = "Çocuk Halısaha Krampon";
            product4.productPrice = 89;
            product4.productRange = "Shoes";

            Product product5 = new Product();
            product5.productBrand = "Fenerium";
            product5.productId = 4592;
            product5.productName = "Lacivert Kaban";
            product5.productPrice = 390;
            product5.productRange = "Outdoor";

            Product[] products = new Product[] { product1, product2, product3, product4, product5 };


            ///////for döngüsü
            ///
            for (int i = 0; i<products.Length; i++)
            {
                Console.WriteLine("Ürün id'si " + products[i].productId + "olan" + products[i].productBrand + "-" + products[i].productName +" fiyat bilgisi: "+ products[i].productPrice +"tl'dir");
            }


            ///////foreach

            foreach (var ürünler in products)
            {
                Console.WriteLine(ürünler.productName +": "+ürünler.productPrice);
            }

            ///////// While döngüsü
            int fb = 1;

            while (fb<products.Length)
            {
                Console.WriteLine(products[fb].productName +" ürününe ait fiyat bilgisi: " + products[fb].productPrice +" tl'dir.");
                fb++;
            }


        }

    }
}
