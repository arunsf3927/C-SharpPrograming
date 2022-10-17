using System;
namespace Exercise4
{
    class program
    {
     public static void Main(string[] args) 
     { 
        Console.WriteLine(" input radius =");
        float radius = float.Parse( Console.ReadLine());
        Console.WriteLine("Height=");
        float height = float.Parse( Console.ReadLine());
        double volume = (3.14*(radius*2)*height);
        Console.WriteLine(volume);

      }
    }
}
