using System;
namespace Ifstatement
{
    class program
    {
     public static void Main(string[] args) 
     {
        Console.WriteLine("Enter mark:");
        int mark = int.Parse( Console.ReadLine());
        if((mark > 80)&&(mark<=100))
        {
            Console.WriteLine("Grad A");
        }
        else if((mark>60)&&(mark<=80))
        {
            Console.WriteLine("grade B");
        }
        else if((mark>35)&&(mark<=60))
        {
            Console.WriteLine("Grade c");
        }
        else if((mark<=35)&&(mark>=0))
        {
            Console.WriteLine("grade D");
        }
        else
        {
            Console.WriteLine("Invalid input");

        }
     }
    }
}
