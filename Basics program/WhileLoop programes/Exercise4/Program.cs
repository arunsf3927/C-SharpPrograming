using System;
namespace Exercise4;

    class program
    {
     public static void Main(string[] args) 
     {
        Console.WriteLine("Enter the input");
        int input=int.Parse (Console.ReadLine());
        while(input==1||input==2||input==3||input==4||input==5)
        {
                Console.WriteLine("Valid");
                input=0;
        }
        Console.WriteLine("invalid");      
    }
    
     }

