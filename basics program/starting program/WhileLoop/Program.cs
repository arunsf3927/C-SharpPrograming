using System;
namespace WhileLoop
{
    class program
    {
     public static void Main(string[] args) 
     {
        int i=0;
        while(i<=25)
        {
            if(i%2==0)
            {
                Console.WriteLine(i);
            }
            i++;
        
        }
        int number;
        Console.WriteLine("Enter the input number");
        bool temp = int.TryParse( Console.ReadLine(),out number);
        while(temp == false)
        {
            Console.WriteLine("input number is a  invalid number");
            Console.WriteLine("Enter the valid number");
             temp = int.TryParse( Console.ReadLine(),out number);
            
        }
        Console.WriteLine("input number is a  valid number");
     }  
    }
}