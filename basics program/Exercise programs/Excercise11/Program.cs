
using System;
namespace Studentsdata
{
    class program
    {
     public static void Main(string[] args)  
     {
        float chemisty= float.Parse(Console.ReadLine());
        Console.WriteLine("physis mark");
        float physis= float.Parse(Console.ReadLine());
        Console.WriteLine("maths mark");
        float maths= float.Parse(Console.ReadLine());
        Console.WriteLine(" your Averge mark is:"+((chemisty+physis+maths)/3));
        Console.WriteLine("Sum is "+(chemisty+physis+maths));
     }
    }
}
