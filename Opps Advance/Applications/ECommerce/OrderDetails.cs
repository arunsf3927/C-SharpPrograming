using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce
{
    public enum OrderStatus { Default, Ordered, Cancelled }
    public class OrderDetails
    {
        private static int _orderID = 1000;

        public string OrderID { get; set; }

        public string CustomerID { get; set; }

        public string ProductID { get; set; }
        
        public double TotalPrice { get; set; }

        public DateTime PurchaseDate { get; set; }

        public int Quantity { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public OrderDetails(string customerID, string productID, double  totalPrice, DateTime purchaseDate, int quantity, OrderStatus orderStatus)
        {
            _orderID++;
            OrderID = $"OID{_orderID}";
            CustomerID = customerID;
            ProductID = productID;
            TotalPrice = totalPrice;
            PurchaseDate = purchaseDate;
            Quantity = quantity;
            OrderStatus = orderStatus;
        }
        public void ShowOrderDetails()
        {
            Console.WriteLine($"   Order ID: {OrderID}   Customer ID: {CustomerID}   Product ID: {ProductID}   Total Price: {TotalPrice}   Purchase Date: {PurchaseDate.ToString("dd/MM/yyyy")}   Quantity Purchased: {Quantity}   Order Status: {OrderStatus.ToString()}");
        }
    }
}
