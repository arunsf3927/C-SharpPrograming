using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace CovidApplication
{
    public  static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("Covid"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("Covid");
            }
            if(!File.Exists("Covid/BeneficiaryClass.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("Covid/BeneficiaryClass.csv");
            }
            if(!File.Exists("Covid/VaccineClass.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("Covid/VaccineClass.csv");
            }
            if(!File.Exists("Covid/VaccinationClass.csv"))
            {
                System.Console.WriteLine("Creating file");
                File.Create("Covid/VaccinationClass.csv");
            }
        }
        public static void ReadFile()
        {
            string[] benificiary=File.ReadAllLines("Covid/BeneficiaryClass.csv");
            foreach(string data1 in benificiary)
            {
                BeneficiaryClass benificiary1=new BeneficiaryClass(data1);
                Operation.benificiaryList.Add(benificiary1);
            }
            string[] Vaccine = File.ReadAllLines("Covid/VaccineClass.csv");
            foreach(string data2 in Vaccine)
            {
                VaccineClass vaccine1=new VaccineClass(data2);
                Operation.VaccineList.Add(vaccine1);
            }
            string [] Vaccination =File.ReadAllLines("Covid/VaccinationClass.csv");
            foreach(string data3 in Vaccination)
            {
                VaccinationClass vaccination1=new VaccinationClass(data3);
                Operation.VaccinationList.Add(vaccination1);
            }
        }
        public static void WriteToFiles()
        {
            string[] benificiaryDetails=new string [Operation.benificiaryList.Count];
            for(int i=0;i<Operation.benificiaryList.Count;i++)
            {
                benificiaryDetails[i]=Operation.benificiaryList[i].RegisterationNumber+","+Operation.benificiaryList[i].Name+","+Operation.benificiaryList[i].Gender+","+Operation.benificiaryList[i].MobileNumber+","+Operation.benificiaryList[i].City+","+Operation.benificiaryList[i].Age;
            }
            File.WriteAllLines("Covid/BeneficiaryClass.csv",benificiaryDetails);
        }
       
    }
}