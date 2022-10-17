using System;
namespace MultiCastingDeligate;
public delegate int Calculator(int n); //Can add methods having int return type & 1 int arg
class Program
{
    static int value =10 ;
    public static int AddNum(int  number){value +=number;return value;}
    public static int MultNum(int number) {value *=number; return value;}
    public static int GetNum() {return value;}
     static void Main(string[] args)
    {
        Calculator nc;
       //Create delegate instances
       Calculator nc1=new Calculator(AddNum);
       Calculator nc2=new Calculator(MultNum);
       //Calling the methods using delegates Objects
       nc=nc1;
       nc+=nc2;
       nc(5);
       System.Console.WriteLine("Value of Num : {0}",GetNum()); 
    }
}
