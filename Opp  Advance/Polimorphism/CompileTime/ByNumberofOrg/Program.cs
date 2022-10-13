using System;
namespace ByNumbersOfOrg;
//method Overloading
class Program
{
    //method with one parameter
    static void Display(int number)
        {
            System.Console.WriteLine("Aruguments :"+number);
        }
        //method with two parameters
        static void Display(int number1, int number2)
        {
            System.Console.WriteLine("arguments :"+number1+"and"+number2);
        }
    static void Main(string[] args)
    {
        Display(1000);
        Display(100,30);
        Console.ReadLine();

    }
}
