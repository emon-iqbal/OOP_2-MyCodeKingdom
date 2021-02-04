using System;

namespace TASK_3
{
    class Grade
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("     --------------- SHOW THE SCORES/MARKS AS GRADES ----------    ");
            Console.WriteLine("     ----------------------------------------------------------    ");


            Console.Write(Environment.NewLine + "     PLACE OBTAiNED MARKS HERE:	  ");
            decimal M = Convert.ToDecimal(Console.ReadLine());
           
            string GRADE;
            if (M < 0)
            {
                GRADE = "SCORES ARE iNVALiD [[MiNiMUM SCORE LiMiT   =   0]]";
            }
            else if ( (M >= 94) && (M <= 100) )
            {
                GRADE = "A+";
            }
            else if ( (M >= 90) && (M < 94) )
            {
                GRADE = "A";
            }
            else if ( (M >= 78) && (M < 90) )
            {
                GRADE = "B";
            }
            else if ( (M >= 66) && (M < 78) )
            {
                GRADE = "C";
            }
            else if ((M >= 50) && (M < 66))
            {
                GRADE = "D";
            }
            else if (M <= 49)
            {
                GRADE = "F";
            }
            else
            {
               GRADE = "SCORES ARE iNVALiD [[MAXiMUM SCORE LiMiT    =   100]]";
            }
            
            Console.WriteLine(Environment.NewLine + "       >>>ULTIMATE GRADE IS :>>  " + GRADE );

            Console.ReadLine();
            Console.ReadKey();

        }
    }
}
