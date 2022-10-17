using System;
namespace CovidApplication;
class program
{
    public static void Main(string[] args)
    {
        Files.Create();
        //Operation.DefaultBenificiary();
       Files.ReadFile();
        Operation.MainMenu();
        Files.WriteToFiles();
    }
}