using System;
namespace Exercise9
{
    class program
    {
        public static void Main(string[] args)
        {
        float a =5;
        float b=18;
            Console.WriteLine("Enter input speed in km/h");
            int Speed=int.Parse(Console.ReadLine());
             Console.WriteLine("Enter Time in sec");
            int Time=int.Parse(Console.ReadLine());
            Console.WriteLine("Distance Travelled="+(Speed*Time*(a/b)));

        }
    }
}