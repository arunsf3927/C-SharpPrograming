using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace ECommerce
{
    public class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("ECommerce"))
            {
                System.Console.WriteLine(("creating Folder"));
                Directory.CreateDirectory("ECommerce");
            }
            if(!File.Exists("ECommerce/CustemerDetails.csv")&&(!File.Exists("ECommerce/OrderDetails.csv")&&(!File.Exists("ECommerce/ProductDetails.csv"))))
            {
                System.Console.WriteLine("Creating file");
                File.Create("ECommerce/CustemerDetails.csv");
                File.Create("ECommerce/OrderDetails.csv");
                File.Create("ECommerce/ProductDetails.csv");
            }
        }
        public static  void ReadFile()
            {
                string[] student=File.ReadAllLines("ECommerce/CustemerDetails.csv") ;
                foreach (string data in student)
                {
                    CustemerDetails student1=new CustemerDetails(data);
                    Operations.StudentList.Add(student1);
                }
            }
        public static void WriteToFiles()
        {
            string[] CustemerDetails=new string [Operations.StudentList.Count];
            for(int i=0;i<Operations.StudentList.Count;i++)
            {
                CustemerDetails[i]=Operations.StudentList[i].RegisterNumber+","+Operations.StudentList[i].Name+","+Operations.StudentList[i].FatherName+","+Operations.StudentList[i].DateofBirth+","+Operations.StudentList[i].Gender+","+Operations.StudentList[i].Phonenumber+","+Operations.StudentList[i].MailId+","+Operations.StudentList[i].Physics+","+Operations.StudentList[i].Chemistry+","+Operations.StudentList[i].Mathematics;
            }
            File.WriteAllLines("ECommerce/CustemerDetails.csv",CustemerDetails);
        }
    }
}