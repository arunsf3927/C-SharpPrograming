using System;
namespace Exercise1
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input String1");
            string  name1 =Console.ReadLine();
             Console.WriteLine("Input String2");
            string  name2=Console.ReadLine();
            if(name1==name2)
            {
                Console.WriteLine("equal");
            }
            else
        {
             Console.WriteLine(" not equal");
            }
           
        }
    }
}