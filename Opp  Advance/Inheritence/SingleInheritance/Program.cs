using System;
namespace SingleInheritance;

class Program
{
public static void Main(string[] args)
{
    PersonalDetails person = new PersonalDetails("Ravi","chan",Gender.Male,1233);
    person.ShowDetails();
     StudentDetails student = new StudentDetails("52522","Ravi","chan",Gender.Male,1233,Department.ECE,"final");
     student.ShowStudent();
        
}
}

