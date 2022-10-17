using System;
namespace Exercise;
class program
{
    public static void Main(string[] args)
    {
        int Answer=0;
        Console.WriteLine("Input the Number");
        int  Table=int.Parse(Console.ReadLine());
        for(int i =1;i<=10;i++)
        {
            Answer= ( Table*i);
            Console.WriteLine(Answer);
             
        }
    }
}
