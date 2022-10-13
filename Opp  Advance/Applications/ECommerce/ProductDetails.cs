using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce
{
    public class ProductDetails
    {
        private static int _productID = 100;

        public string ProductID { get; set; }

        public string ProductName { get; set; }

        public double Price { get; set; }

        public int Stock { get; set; }

        public double ShippingDuration { get; set; }
        
        public ProductDetails(string productName, double price, int stock, double shippingDuration)
        {
            _productID++;
            ProductID = $"PID{_productID}";
            ProductName = productName;
            Price = price;
            Stock = stock;
            ShippingDuration = shippingDuration;
        }

        public void ShowProductDetails()
        {
            Console.WriteLine($"Product ID: {ProductID}   Product Name: {ProductName}   Available Stock: {Stock}   Price per quantity: {Price}   Shipping Duration: {ShippingDuration}");
        }
    }
}
