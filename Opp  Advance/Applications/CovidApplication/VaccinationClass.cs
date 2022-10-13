using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidApplication;
public enum DoseNumber{Default,one,two,three}

    public class VaccinationClass
    {
       public static int s_vaccinationId=1000;
       public  string VaccinationId{get;set;}
       public DoseNumber DoseNumber{get;set;}
       public DateTime VaccinatedDate{get;set;}
       public VaccinationClass(string  registerNumber ,string vaccinationid, DoseNumber doseNumber,DateTime vaccinatedDate)
       {
        s_vaccinationId++;
        VaccinationId="VID"+s_vaccinationId;
        DoseNumber=doseNumber;
        VaccinatedDate=vaccinatedDate;
       }
       public VaccinationClass(string data)
       {
         string[] values = data.Split(',');
            s_vaccinationId=int.Parse(values[0].Remove(0,2));
            DoseNumber=Enum.Parse<DoseNumber>(values[1]);
            VaccinatedDate=DateTime.ParseExact(values[2],"dd/MM/yyyy",null);            
       }
    }
