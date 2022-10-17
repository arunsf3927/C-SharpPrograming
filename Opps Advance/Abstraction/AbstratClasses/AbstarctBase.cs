using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratClasses;
    public  abstract class AbstarctBase
    {
        protected string name; //Noraml fied  //No Abstarct field //interce and class inherite // abstract donot be static
        public abstract string Name{ get; set; } //Abstarct Property
        public double Amount { get; set; } //Normal  property
        public void Display(){System.Console.WriteLine(name);} //Normal Method
        public abstract void Salary(int dates); //Abstarct Method
}