using System;
namespace Exercise2;

    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Age of the canditate");
            int age =int.Parse(Console.ReadLine());
            if(age>=18)
            {
                Console.WriteLine("Congratulation !/ You are eligible for casting your vote.");
            }
            else
            {
                Console.WriteLine("You is not eligible for voting");
            }
        }
    }

