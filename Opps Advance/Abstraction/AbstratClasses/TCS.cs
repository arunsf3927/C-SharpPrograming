using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratClasses
{
    public class TCS:AbstarctBase
    {
        //Abstarct property defination
        public override string Name{get{return name;}set{name=value;}}
        //Abstarct Method defintion
        public override void Salary(int dates)
        {
           Display();
           Amount =(double)dates*300;
           System.Console.WriteLine(Amount);
        }
    }
}