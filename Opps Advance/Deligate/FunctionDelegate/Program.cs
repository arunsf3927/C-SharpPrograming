using System;
namespace FunctionDelegate;
class Program
{
    static double Sum(int a,int b) {return a+b;}
    static double Subract(int a, int b)  {return a-b;}
    static double Calculator (Func<int,int,double> operation,int x,int y)
                                   //a  //b  //return type //nc 
    {
        return operation(x,y);
    }
    public static void Main(string[] args)
    {
        System.Console.WriteLine(Calculator(Sum,10,20));
        System.Console.WriteLine(Calculator(Subract,10,20));
    }
}