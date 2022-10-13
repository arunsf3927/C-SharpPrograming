using System;
namespace Exercise6
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n=1;
            int sum =0;
            while(n>0)
            {
                Console.WriteLine("Enter number1");
                int number1=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number2");
                int number2=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number1");
                int number3=int.Parse(Console.ReadLine());
                sum =(number1+number2+number3);
                Console.WriteLine("Sum of digits of "+number1+number2+number3+ " is "+sum);
                n=0;
            }
            
        }
    }
}