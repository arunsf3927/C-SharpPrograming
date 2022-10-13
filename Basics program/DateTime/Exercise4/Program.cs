using System;
namespace Exercise4
{
    class program4
    {
        public static void Main(string[] args)
        {
            DateTime New=new DateTime(2016,7,11);
            Console.WriteLine("{0:d} is {1}",New, New.DayOfWeek);
        }
    }
}