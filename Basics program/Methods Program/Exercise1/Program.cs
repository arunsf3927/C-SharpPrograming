using System;
namespace Exercise1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int sum=0;
            int  sub=0;
            int Product=0;
            int divide=0;
            Console.WriteLine("Enter the number1 :");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number2:");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the choice: ");
            int Choice = int.Parse(Console.ReadLine());
            switch(Choice)
            {
                case 1:
                {
                    Console.WriteLine(Addition(number1,number2));
                    break;
                }
                case 2:
                {
                    Subraction(number1,number2);
                    break;
                }
                case 3:
                {
                    Multiplication(number1,number2);
                    break;
                }
                case 4:
                {
                    Console.WriteLine(Division(number1,number2));
                    break;
                }
            }
            //with Arg with return type
            int Addition(int value1,int value2)
            {
                sum = value1+value2;
                return sum;
            }
            //with arg without return type
            void Subraction(int value1, int value2)
            {
                sub =value1-value2;
                Console.WriteLine(sub);
            }
            //without Arg without return type
            void Multiplication(int value1,int value2)
            {
                Product=value1*value2;
                Console.WriteLine(Product);
            }
            //without arg with return type
            int Division(int value1,int value2)
            {
                divide=value1/value2;
                return (divide);
            }
        }
    }
}
