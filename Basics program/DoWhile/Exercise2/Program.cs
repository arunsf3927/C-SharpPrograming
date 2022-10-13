using System;
namespace Exercise2
{
    class program
    {
        public static void Main(string[] args)
        {
            do 
            {
                Console.WriteLine("Enter number1");
                int number1=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number2");
                int number2=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number3");
                int number3=int.Parse(Console.ReadLine());
                int sum =number1+number2+number3;
                Console.WriteLine(sum);
            }
            while()
        }
    }
}