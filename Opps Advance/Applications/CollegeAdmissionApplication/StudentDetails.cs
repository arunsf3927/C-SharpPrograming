using System;

using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmissionApplication
{
    public enum Gender{Default,Male,Female,Transgender}
    public class StudentDetails
    {
         private static int s_registernumber=3000;
        
        public string RegisterNumber { get;  }
        
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime DateofBirth { get; set; }
        public Gender Gender { get; set; }
        public long Phonenumber { get; set; }
        public string MailId { get; set; }
        public int Physics { get; set; }
        public int  Mathematics { get; set; }
        public int  Chemistry { get; set; }
        

        public StudentDetails(string name,string fatherName ,DateTime datofBirth,Gender gender,long PhoneNumber,string mailId,int physics,int chemistry,int maths )
        {
            s_registernumber++;
            RegisterNumber="SF"+s_registernumber;
            Name=name;
            FatherName=fatherName;
            DateofBirth=datofBirth;
            Gender=gender;
            Phonenumber=PhoneNumber;
            MailId=mailId;
            Chemistry=chemistry;
            Mathematics=maths;

        }
        public StudentDetails(string data)
        {
            string[] values = data.Split(',');
            s_registernumber= int.Parse(values[0].Remove(0,6));
            RegisterNumber=values[0];
            Name=values[1];
            FatherName=values[2];
            Gender= Enum.Parse<Gender>(values[3]);
            Physics=int.Parse(values[4]);
            Chemistry=int.Parse(values[5]);
            Mathematics=int.Parse(values[6]);
        }
          public bool CheckEligibility(double cutOff)
            {
                double average=(double)(Physics+Chemistry+Mathematics/3.0);
                if(average>=cutOff)
                return(true);
                else
                return(false);
                
            }
            public void ShowDetails()
            {
                
                System.Console.WriteLine("Register Number is:"+RegisterNumber);
                System.Console.WriteLine($"Register number:{RegisterNumber}\nName is:{Name}\nFather's Name is:{FatherName}\nDOB:{DateofBirth}\nGender:{Gender}\nPhoneNumber:{Phonenumber}\nMail ID:{MailId}\nPhysics Marks:{Physics}\nChemistry Marks:{Chemistry}\nMaths Marks:{Mathematics}"); 
            
            }
           
        


    }
}