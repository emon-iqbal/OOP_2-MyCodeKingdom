using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COURSE
{
    class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;


        private void SetCourse(string COURSE_NAME, string COURSE_CODE, int COURSE_CREDIT)
        {
            courseName = COURSE_NAME;
            courseCode = COURSE_CODE;
            courseCredit = COURSE_CREDIT;
        }

        private string GetcourseName()
        {
            return courseName;
        }
        
        private string GetcourseCode()
        {
            return courseCode;
        }

        private int GetcourseCredit()
        {
            return courseCredit;
        }

        
        
        private void ShowCourseInfo()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("  >>>>> S E L E C T E D      C O U R S E      N A M E                          ###   " + GetcourseName());
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("  >>>>> C O D E      O F      T H E      S P E C i F i E D      C O U R S E    ###   " + GetcourseCode());
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("  >>>>> T O T A L      C R E D i T      F O R      T H E      C O U R S E      ###   " + GetcourseCredit());

        }
        
        
        
        static void Main(string[] args)
        {
            Course oop2 = new Course();
            oop2.SetCourse("W E B   T E C H N O L O G Y", "CSC3222", 3);
            oop2.ShowCourseInfo();

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
