using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public class MedicineDetailsClass
    {
       private static int s_medicineId=100;
       public string MedicineId{get;set;}
       public string MedicineName{get;set;}
       public   int AvailableCount{get;set;}
       public double Price{get;set;}
       public DateTime DateOfExpiry{get;set;}
       public MedicineDetailsClass(string medicineName,int availableCount,double price,DateTime dateOfExpiry)
       {
        s_medicineId++;
        MedicineId="MD"+100;
        MedicineName=medicineName;
        AvailableCount=availableCount;
        Price=price;
        DateOfExpiry=dateOfExpiry;  
       }
       public MedicineDetailsClass(string data)
       {
        string[] values=data.Split(',');
        s_medicineId=int.Parse(values[0].Remove(0,4));
        MedicineName=values[1];
        AvailableCount=int.Parse(values[2]);
        Price=double.Parse(values[3]);
        DateOfExpiry=DateTime.ParseExact(values[4],"dd/MM/yyyy",null);
       }
    }
}