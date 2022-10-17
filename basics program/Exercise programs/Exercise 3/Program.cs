using System;
namespace Studentsdata
{
    class program
    {
     public static void Main(string[] args) 
     {
        Console.WriteLine("Enter the amount of Celsius:");
        float Celsius = float.Parse( Console.ReadLine());
        float kelvin = (Celsius +273);
        float number1=9;
        float number2 =5;
        float Fahrenheit = (Celsius *(number1/number2)+32);
        Console.WriteLine("kelvin ="+kelvin);
        Console.WriteLine("Fahrenheit ="+Fahrenheit);

     } 
    }
}
