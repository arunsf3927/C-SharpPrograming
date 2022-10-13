using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmission
{
  public enum Gender{Default,Male,Feamle,transgender}
    public class StudentDetails
    {
      
       // private string _name;//Field decllaration
       // public string  Name { get{return _name;} set{;_name=value; } }//properties declaration
       public string Name { get; set; } //Autoproperty declaration
       public string FatherName { get; set; }
       public DateTime DOB { get; set; }
       public Gender Gender { get; set; }
       public long Phone { get; set; }
       public string Mail { get; set; }
        public int Maths { get; set; }
         public int Chemistry { get; set; }
          public int Physics { get; set; }
          /*public StudentDetails() //Default constructor
          {
            Name="Your name";
            FatherName="Your Father Name";
            Mail="Your mail id";
          }*/
          //parameterised constructor
          public StudentDetails(string name,string fatherName,DateTime dob,string mail,long phone,int maths,int physics,int chemistry)
          {
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Maths=maths;
            Physics=physics;
            Chemistry=chemistry;
            DOB=dob;
          }
          public bool CheckEligibilty(double cutoff)
          {
            double average=(double)(Physics+Chemistry+Maths)/0.3;
            if(average>=cutoff)
            {
              return true;
            }
            else
            {
              return false;
            }
          }
       
    } 
}