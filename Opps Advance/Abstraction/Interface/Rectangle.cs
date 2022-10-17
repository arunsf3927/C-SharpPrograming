using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public interface IRectangle
    {
      int Length{get;set;}
      int Breath {get;set;}  
      void CalculateArea();

    }
    
}