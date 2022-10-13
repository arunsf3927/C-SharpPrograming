using System;
namespace Exercise1
{
    class program
    {
     public static void Main(string[] args)  
     {
        Console.WriteLine("Input the first number");
        float fisrtnumber= float.Parse(Console.ReadLine());
        Console.WriteLine("Input the second number: ");
        float secondnumber= float.Parse(Console.ReadLine());
        float addtion = fisrtnumber + secondnumber;
        float  subraction = fisrtnumber- secondnumber;
        float multiplication = fisrtnumber * secondnumber;
        float division = fisrtnumber / secondnumber;
        float percentage = fisrtnumber % secondnumber;
        Console.WriteLine(+fisrtnumber+ "+" +secondnumber+ "="+addtion);
        Console.WriteLine(+fisrtnumber+ "-" +secondnumber+ "="+subraction);
        Console.WriteLine(+fisrtnumber+ "*" +secondnumber+"=" +multiplication);
        Console.WriteLine(+fisrtnumber+ "/" +secondnumber+ "="+division);
        Console.WriteLine(+fisrtnumber+ "%" +secondnumber+ "="+ percentage);

     }
    }
}