using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENT
{
    class Student
    {
        private string  name;
        private string  ID;
        private string  department;
        private double  cgpa;


        private void SetStudent(string Sname, string sID, string Sdepartment, double Scgpa)
        {
            name       = Sname;
            ID         = sID;
            department = Sdepartment;
            cgpa       = Scgpa;
            
        }


        private string Getname()
        {
            return name;
        }
        
        private string GetID()
        {
            return ID;
        }

        private string Getdepartment()
        {
            return department;
        }

        private double Getcgpa()
        {
            return cgpa;
        }


        private void ShowInfo()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            
            Console.WriteLine("     STUDENT NAME        ::   " + Getname());
            Console.WriteLine("     STUDENT ID          ::   " + GetID());
            Console.WriteLine("     DEPARTMENT          ::   " + Getdepartment());
            Console.WriteLine("     CURRENT C.G.P.A     ::   " + Getcgpa());
            
        }
        
        
        static void Main(string[] args)
        {
            Student E = new Student();
            E.SetStudent("EMON", "16-32332-2", "C.S.E", 3.24);
            E.ShowInfo();

            Console.ReadLine();
            Console.ReadKey();

        }
    }
}
