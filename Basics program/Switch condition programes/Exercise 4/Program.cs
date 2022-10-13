// See https://aka.ms/new-console-template for more information
using System;
namespace Switchcondition
{
    class program
    {
     public static void Main(string[] args) 
     {
            int  firstInteger = 10;
            int secondInteger = 2;
        Console.WriteLine("Input Your choice");
        int choice=int.Parse(Console.ReadLine());
         switch(choice)
         {
            case 1:
            {
                float addition=(firstInteger + secondInteger);
                Console.WriteLine("Addition of 10 and option 2  is "+addition);
                break;
            }
            case 2:
            {
                float subration =(firstInteger - secondInteger);
                Console.WriteLine("Subration of 10 and option 2 is "+subration);
                break;
            }
            case 3:
            {
            float Multiplication=(firstInteger * secondInteger);
            Console.WriteLine("Multiplicaytion of 10 and option is  2 is " +Multiplication);
            break;
            }
             case 4:
             {
            float division=(firstInteger / secondInteger);
            Console.WriteLine(" Divisionof 10 and option 2 is "+division);
            break;
             }
             case 5:
             {
            
             Console.WriteLine("Exit");
             break;
             }
             default:
             {
                Console.WriteLine("Invalid choice");
                break;
             }
         
         }     
     }
    }
}