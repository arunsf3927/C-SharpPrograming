using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryApplication
{
    public class FoodDetails
    {
        private static int s_foodid=100;
        public string FoodId{get;set;}
        public string FoodName{get;set;}
        public int PriceQuantity{get;set;}
        public FoodDetails(string foodName,int priceQuantity )
        {
            
        }
    }
}