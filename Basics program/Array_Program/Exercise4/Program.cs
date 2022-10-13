using System;
namespace Exercise1
{
    class program
    {
        public static void Main(string[] args)
        {
            string[] Input=new string[3];
            for(int i =0;i<3;i++)
            {
                Console.WriteLine("Input elements in the array");
                Input[i]=Console.ReadLine();
            }
             for(int i=0;i<3;i++)
            {    
             Console.WriteLine(Input.Max());
            }      
        }
    }
}
