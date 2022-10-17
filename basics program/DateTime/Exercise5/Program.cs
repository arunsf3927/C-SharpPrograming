using System;
namespace Exersice5
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime dec31 = new DateTime(2000,12,31);
            for (int ctr =0; ctr<=20;ctr++)
            {
                DateTime dateToDisplay = dec31.AddYears(ctr);
                Console.WriteLine("{0:d}:day{1} of {2} {3}",dateToDisplay,dateToDisplay.DayOfYear,DateTime.IsLeapYear(dateToDisplay.Year)?"(Leap Year)":"");
            }
        }
    }
}
