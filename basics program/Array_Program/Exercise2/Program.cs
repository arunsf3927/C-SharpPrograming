using System;
namespace exercise2
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Input the number of elements to store in the array :");
            int Size=int.Parse(Console.ReadLine());
            string[] Number=new string [Size];
            for (int i=0;i<Size;i++)
            {
                Console.WriteLine("Enter the Number of elements");
                Number[i]=Console.ReadLine();
            }
            for(int j=0 ;j<Size;j--)
            {
               Console.WriteLine("The elements are :"+Number[j]);
            }
        }
    }
}
