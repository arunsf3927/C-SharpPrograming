using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance;

    public class CustemerDetails:PersonalDetails
    {
        private static int s_custemerId=1000;
        public string CustemerId{get;set;}
        public double Balance{get;set;}
        public CustemerDetails(string adharId,string name,string fatherName,Gender gender,long phoneNumber):base(adharId,name,fatherName,gender,phoneNumber)
        {
            s_custemerId++;
            CustemerId="CID"+s_custemerId;
        }
        public void Recharge()
        {
            System.Console.WriteLine("Enter the amount");
            Balance+=double.Parse(Console.ReadLine());
        }
        public void Show()
        {
            System.Console.WriteLine("Custemer Id"+CustemerId);
            ShowDetails();
            System.Console.WriteLine("Balance"+Balance);
        }
    }
