using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankApplication
{
    public class DonationClass
    {
        public static int s_DonationId=1000;
        public  string  DonationId {get;set;}
        public  int DonorId {get;set;}
        public DateTime DonationDate{get;set;}
        public int Weight{get;set;}
        public int HemoglobinCount{get;set;}
        public DonationClass(int donorId,DateTime donationDate,int weight,int hemoglobinCount)
        {
            s_DonationId++;
            DonationId=DonationId;
            DonorId=DonorId;
            DonationDate=donationDate;
            Weight=weight;
            HemoglobinCount=hemoglobinCount;
        }
    }
}