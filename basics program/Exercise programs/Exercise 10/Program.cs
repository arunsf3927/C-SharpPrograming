using System;
namespace Exercise10
{
    class program
    {
        public static void Main(string[] args)
        {
            int Value1=15;
            int Value2=20;
            int stringValue = Value1;
            System.Console.WriteLine("a. "+(Value1 > Value2));
            System.Console.WriteLine("b. "+(Value1 < Value2));
           System.Console.WriteLine("c. "+(Value1 >= Value2));
            System.Console.WriteLine("d. "+(Value1 == Value2));
            System.Console.WriteLine("e. "+(Value1 != Value2));
            System.Console.WriteLine("f. "+(Value1 <= Value2));
            System.Console.WriteLine("g. "+(Value1 >=10 && Value2 >=10));
            System.Console.WriteLine("h. "+(Value1 >=10 && Value2 >=30));
            System.Console.WriteLine("i. "+!((Value1>20)));
            System.Console.WriteLine("j. "+(stringValue == Value1)+":"+"False");
            System.Console.WriteLine("k. "+(++Value1 ));
            System.Console.WriteLine("l. "+(--Value1 ));
            












        }
    }
}