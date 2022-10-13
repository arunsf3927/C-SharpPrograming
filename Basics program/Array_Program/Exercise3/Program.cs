using System;
namespace Exercise3
{
    class Program
    {
        public static void Main(string[] args)
        {
            string sum ="";
            Console.WriteLine("Enter the size of the elements");
            int Size =int.Parse(Console.ReadLine());
            String[] New = new string[Size];
            for(int i=0; i>Size;i++)
            {
            sum +=New[i];
            Console.WriteLine(sum);
            }

        }
    }
}
