using System;

class dttimeex51
{
    static void Main()
    {
    Console.Write("\n\n Display the name of the months of a year :\n");
 Console.Write("-----------------------------------------------\n");
 DateTime now = DateTime.Now;
 Console.WriteLine(" The date of Today : {0}",now.ToString("dd/MM/yyyy"));
 Console.WriteLine(" The twelve months are :");
 for (int i = 0; i < 12; i++)
 {
     Console.WriteLine(" {0}",now.ToString("MMMM"));
     now = now.AddMonths(1);
 }
 Console.WriteLine();
    }
}

