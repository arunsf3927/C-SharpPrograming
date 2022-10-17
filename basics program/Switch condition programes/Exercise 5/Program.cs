// See https://aka.ms/new-console-template for more information
using System;
namespace Switchcondition
{
    class program
    {
     public static void Main(string[] args) 
    {
        Console.WriteLine("Input Your choice");
        string State= Console.ReadLine();
         switch(State)
        {
            case "india":
            {
                Console.WriteLine("1.Gambir,Ashwin,Dhoni,Jadeja");
                break;
            }
            case "Pakistan":
            {
                
                Console.WriteLine("1.imran Thakur  2.Jai, 3.kl rk");
                break;
            }
            case "Bangladesh":
            {
            Console.WriteLine("1.Nami , 2.Chakal, 3.Rakul");
            break;
            }
            
            default:
            {
            Console.WriteLine("Invalid State");
                break;
             }
        }
    }
         
              
    }
}


