using System;
namespace OperatorOverLoading;
class Program
{
    public static void Main(string[] args)
    {
        Box box1=new Box(1.2,9.3,6.6);
        Box box2=new Box(1.8,4.3,9.6);
        Box box3 ;
        double volume =0.0;

        //vol box 1
        volume=box1.CalculateVolume();
        System.Console.WriteLine("Volume of Box1 :{0}",volume);

        //vol box 2
        volume=box2.CalculateVolume();
        System.Console.WriteLine("Volume of Box2 :{0}",volume);
        box3=box1 + box2;

        //vol box 3
        volume=box1.CalculateVolume();
        System.Console.WriteLine("Volume of Box3 :{0}",volume);
    }
}
