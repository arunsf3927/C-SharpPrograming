// See https://aka.ms/new-console-template for more information
using System;
namespace Exercise7;
class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Customer IDNO ");
        double IDNO=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Customer Name  ");
        double Name=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the unit Consumed ");
        double Unit=int.Parse(Console.ReadLine());
        if(Unit>0&&Unit>=200)
        {
           Unit*=(1.20);

        }
        else if(Unit>8200&&Unit<400)
        {
           Unit*=(1.50);    
        }
        else if(Unit>=400&&Unit<600)
        {
           Unit*=(1.50);  
        }
        else if(Unit>=600)
        {
           Unit*=(2.000);
        }
        double sure=0; double= unitamount=Unit;
        if(unitamount>400)
        {sure=unitamount*(0.15);
            sure=unitamount
        }
        double=totalamount=Unit+sure;
        Console.WriteLine(cl)
    }
    }
    }
}
