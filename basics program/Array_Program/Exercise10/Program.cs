using System;
namespace Exercise1
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input User name");
            string  name1 =Console.ReadLine();
             Console.WriteLine("Input password");
            string  name2=Console.ReadLine();
            if(name1=="user"&&name2=="pass")
            {
                Console.WriteLine("Password entered successfully!");
            }
            else
        {
             Console.WriteLine(" Password  not entered successfully!");
            }     
        }
    }
}
