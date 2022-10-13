using System;
namespace DatTime;
class Program
{
    public static void Main(string[] args)
    {
        
        DateTime date = new DateTime(2021,8,10,10,40,32);
        Console.WriteLine("Year: "+date.Year);
        Console.WriteLine("Month :"+date.Day);
        Console.WriteLine("Hour :"+date.Hour);
        Console.WriteLine("Minute :"+date.Minute);
        Console.WriteLine("Second :"+date.Second);
        Console.WriteLine(date.ToString("dd/MM/yyyy hh:mm:ss"));
        string news = Console.ReadLine();
        Console.WriteLine(news)
    }
}
