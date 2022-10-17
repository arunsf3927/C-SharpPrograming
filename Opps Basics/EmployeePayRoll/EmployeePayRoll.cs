using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayRoll
{
      public enum Location{Default,Madura, Eymard}
    public class EmployeePayRoll
    {
       
        public string Name{get;set;}   
        public string Role{get;set;}
        public Location location {get; set;}
        public string TeamName {get; set;}
        public DateTime DOJ{get; set;}
         public EmployeePayRoll(string name,string role,Location location,DateTime doj, string teamname)
        {
            Name=name;
            Role=role; 
            Location=location;
            DOJ=doj;
            TeamName=teamname;

        }
          public void CalculateSalary()
        {
            System.Console.WriteLine("Number of days worked");
            int work=int.Parse(Console.ReadLine());
            int salary1=500*work;
            System.Console.WriteLine("Your Balance :"+salary1);
            System.Console.WriteLine("Enter the amount");

    }
    }
}