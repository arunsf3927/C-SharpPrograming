using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedMethod
{
    public class Dog:Animal
    {
        public override void MakeSound()//Method Sealing
        
        {
           System.Console.WriteLine("Dog Sound");
        }
    }
}