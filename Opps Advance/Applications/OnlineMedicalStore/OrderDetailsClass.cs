using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public enum OrderStatus{Default,purchased,cancelled}
    public class OrderDetailsClass
    {
        private static int s_orderId=2001;
        public string OrderId{get;set;}
        public  int UserId{get;}
        public int MedicineId{get;}
        public int MedicineCount{get;set;}
        public double TotalPrice{get;set;}
        public DateTime OrderDate{get;set;}
        public OrderStatus OrderStatus{get;set;}
        public OrderDetailsClass(int userId,int medicineId,int medicineCount,int totalPrice, DateTime orderDate,OrderStatus orderStatus)
        {
            s_orderId++;
            OrderId="OID"+s_orderId;
            UserId=userId;
            MedicineId=medicineId;
            MedicineCount=medicineCount;
            TotalPrice=totalPrice;
            OrderDate=orderDate;
            OrderStatus=orderStatus;
        }
        public OrderDetailsClass(string data)
        {
            string [] values = data.Split(',');
            s_orderId=int.Parse(values[0].Remove(0,5));
            UserId=int.Parse(values[1]);
            MedicineId=int.Parse(values[2]);
            MedicineCount=int .Parse(values[3]);
            TotalPrice= int.Parse(values[4]);
            OrderDate = DateTime.Parse(values[5]);
            OrderStatus=Enum.Parse<OrderStatus>(values[1]);
        }
    }
}