using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace FoodDeliveryApplication
{
    public class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("FoodDelivery"))
            {
                System.Console.WriteLine("Folder not found");
                Directory.CreateDirectory("FoodDelivery");
            } 
              if(!File.Exists("FoodDelivery/CustemerDetails.csv"))
                {
                    System.Console.WriteLine("File not found");
                    File.Create("FoodDelivery/CustemerDetails.csv");
                }
        }
        public static void Readfile()
        {
            string [] person =File.ReadAllLines("FoodDelivery/CustemerDetails.csv");
            foreach(string data in person)
            {
                CustemerRgistrationClass person1 = new CustemerRgistrationClass(data);
                Operation.CustemerRgistrationList.Add(person1 );
            }
        }
        public static void WriteToFile()
        {
            string[] personw =new string[Operation.CustemerRgistrationList.Count];
            for(int i=0;i<Operation.CustemerRgistrationList.Count;i++)
            {
                personw[i]=Operation.CustemerRgistrationList[i].Name+","+Operation.CustemerRgistrationList[i].FatherName+","+Operation.CustemerRgistrationList[i].Gender+","+Operation.CustemerRgistrationList[i].MobileNumber+","+Operation.CustemerRgistrationList[i].DOB+","+Operation.CustemerRgistrationList[i].MailId+","+Operation.CustemerRgistrationList[i].Location;
            }
            File.WriteAllLines("FoodDelivery/CustemerDetails.csv",personw);
        }
    }
}