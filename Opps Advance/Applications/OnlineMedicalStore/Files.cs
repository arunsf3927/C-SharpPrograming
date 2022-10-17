using System;
using System.Collections.Generic;
using System.IO;

namespace OnlineMedicalStore
{
    public  static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("OnlineMedicalStore"))
            {
                System.Console.WriteLine("Folder not Found So creating a folder");
                Directory.CreateDirectory("OnlineMedicalStore");
            }
            if(!File.Exists("OnlineMedicalStore/UserDetails.csv"))
            {
                System.Console.WriteLine("File was not found so you can create a file");
                File.Create("OnlineMedicalStore/UserDetails.csv");
            }
            if(!File.Exists("OnlineMedicalStore/MedicineDetailsClass.csv"))
            {
                System.Console.WriteLine("File was not found so you can create a file");
                File.Create("OnlineMedicalStore/MedicineDetailsClass.csv");
            }
            if(!File.Exists("OnlineMedicalStore/OrderDetailsClass.csv"))
            {
                System.Console.WriteLine("File was not found so you can create a file");
                File.Create("OnlineMedicalStore/OrderDetailsClass.csv");
            }
        } 
        public static void ReadFile()
        {
            string[] user =File.ReadAllLines("OnlineMedicalStore/UserDetails.csv");
            foreach(string data in user)
            {
                UserDetailsClass user1=new UserDetailsClass(data);
                Operation.UserDetailsList.Add(user1);
            }
            
            string[] medicine=File.ReadAllLines("OnlineMedicalStore/MedicineDetailsClass.csv");
            foreach(string data2 in medicine)
            {
                MedicineDetailsClass medicine2=new MedicineDetailsClass(data2);
                Operation.MedicineDetailList.Add(medicine2);
            }
        }
        public static void WriteToFiles()
        {
            string[] userDeatils=new string [Operation.UserDetailsList.Count];
            for(int i=0;i<Operation.UserDetailsList.Count;i++)
            {
                userDeatils[i]=Operation.UserDetailsList[i].UserId+","+Operation.UserDetailsList[i].UserName+","+Operation.UserDetailsList[i].Age+","+Operation.UserDetailsList[i].City+","+Operation.UserDetailsList[i].PhoneNumber+","+Operation.UserDetailsList[i].Balance;
            }
            File.WriteAllLines("OnlineMedicalStore/UserDetails.csv",userDeatils);
            string[] medicineDetails =new string [Operation.MedicineDetailList.Count];
            for(int i=0;i<Operation.MedicineDetailList.Count;i++)
            {
            medicineDetails[i]=Operation.MedicineDetailList[i].MedicineName+","+Operation.MedicineDetailList[i].AvailableCount+","+Operation.MedicineDetailList[i].Price;
            }
            File.WriteAllLines("OnlineMedicalStore/MedicineDetailsClass.csv",medicineDetails);
    }
}
}