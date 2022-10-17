using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public class Draw:IRectangle
    {
        public int Area { get; set; }
        public int Length{get;set;}
        public int Breath {get;set;}
        public void CalculateArea()
        {
            Area=Length*Breath;
            System.Console.WriteLine("Area of rectangle"+Area);
        }  
    }
}