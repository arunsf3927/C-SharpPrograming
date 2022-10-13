using System;
namespace HierarchyInheritance;

class Program
{
public static void Main(string[] args)
{
    PersonalDetails person = new PersonalDetails("Ravi","chan",Gender.Male,1233);
    person.ShowDetails();
    StudentDetails student = new StudentDetails("52522","Ravi","chan",Gender.Male,1233,Department.ECE,"final");
    student.ShowStudent();
    CustemerDetails custemer= new CustemerDetails("1233","ary","gagas",Gender.Male,1233);
    custemer.Recharge();
    custemer.Show();
        
}
}

