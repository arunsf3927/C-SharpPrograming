using System;
namespace ByType;
class Progarm
{
    //method with int Parameter
    static void  Display(int number)
    {
        System.Console.WriteLine("int type :"+number);
    }
    //method with string Parameter
    static void Display(string name)
    {
        System.Console.WriteLine("string Type :"+name);
    }
    public static void Main(string[] args)
    {
      Display(100);
      Display("Arun")
      ;Console.ReadLine();  
    }
}
