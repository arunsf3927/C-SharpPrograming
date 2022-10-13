using System;
namespace Exercise2
{
    class program
    {
     public static void Main(string[] args) 
     {
        
        string check = "";
        do
        {
            Console.WriteLine("Enter your number");
            int number=int.Parse( Console.ReadLine());
            if(number%2==0)
            {
                Console.WriteLine("The given number is even");
            }
            else
            {
                Console.WriteLine("The given number is odd");
         
            }
           Console.WriteLine("You want to repeat the process");
           check=Console.ReadLine().ToLower();
           if(check!= "yes"&& check!="no")
           {
               Console.WriteLine("The input is Invalied");
           }
           
        }
         while(check=="yes");
    
     }   
    }
}
    
