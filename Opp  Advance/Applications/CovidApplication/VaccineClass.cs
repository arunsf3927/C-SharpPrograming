using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidApplication;
public enum VaccineName{Default,Covishield, Covaccine}

    public class VaccineClass
    {
         private  static int s_vaccineId=100;
        public string VaccineId{get;set;}
        public VaccineName VaccineName{get;set;}
        public int NumberOfDoseAvailable{get;set;}
        public VaccineClass(VaccineName vaccineName,int numberOfDoseAvailable)
        {
            s_vaccineId++;
            VaccineId="CID"+s_vaccineId;
            VaccineName=vaccineName;
            NumberOfDoseAvailable=numberOfDoseAvailable;    
        }
        public VaccineClass(string data)
        {
             string[] values = data.Split(',');
            s_vaccineId=int.Parse(values[0].Remove(0,1));
            VaccineName=Enum.Parse<VaccineName>(values[0]);
            NumberOfDoseAvailable=int.Parse(values[1]);
        }

    }
