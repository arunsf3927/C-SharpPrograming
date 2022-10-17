using System;
namespace Exercise5
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the   number");
            int number =int.Parse(Console.ReadLine());
            output();
            void output()
            {
                if(number%2==0)
                {
                    Console.Write("Prime number");
                }
                else
                {
                  Console.WriteLine("not a prime number");  
                }
                
            }
        }
    }
}
