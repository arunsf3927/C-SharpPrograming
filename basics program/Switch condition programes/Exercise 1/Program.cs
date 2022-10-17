// See https://aka.ms/new-console-template for more information
using System;
namespace Exercise1;
class program
{
        public static void Main(string[] args)
        {
          Console.WriteLine("Enter the Grade");
          char grade =char.Parse( Console.ReadLine());
        switch(grade)
        {
           case 'E':
           {

                Console.WriteLine("Excelent");
                break;
           }
           case 'V':
           {
            Console.WriteLine("Very Good");
            break;
           }
           case 'A':
        {
            Console.WriteLine("Average");
            break;
        }
        case 'F':
        {
            Console.WriteLine("Fail");
            break;
        }
        }
 }   
}
