using System;
namespace Exercise4;
class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input the 1st number ");
        int number1= int.Parse(Console.ReadLine());
        Console.WriteLine("Input the 2nd number ");
        int number2= int.Parse(Console.ReadLine());
        Console.WriteLine("Input the 3rd number ");
        int number3= int.Parse(Console.ReadLine());
        if(number1>number2&&number1>number3)
        {
            Console.WriteLine("The 1st Number is the greatest among three");
        }
        else if(number2>number1&&number2>number3)
        {
            Console.WriteLine("The 2nd Number is the greatest among three");
        }
        else
        {
            Console.WriteLine("The 3rd Number is the greatest among three");
        }


    }
}
