using System;
namespace FoodDeliveryApplication;
using System.IO;
class Program
{
    public static void Main(string[] args)
    {
        Files.Create();
        Files.Readfile();
        Operation.MainMenu();
        Files.WriteToFile();
    }
}
