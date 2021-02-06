using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABTASK_2___CV___USER_INPUT__
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("                             ---------------------------------------   ");
            Console.WriteLine("                                         PERSONAL INFORMATIONS         ");
            Console.WriteLine("                          ---------------------------------------      ");

            Console.WriteLine(Environment.NewLine);

//
//  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ USER iNPUT SETUP CODELINES ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//

            Console.Write("             1.  NAME                :   ");
            string NAME;
            NAME = Console.ReadLine();

            
            Console.Write("             2.  DESIGNATION         :   ");
            string dsg;
            dsg = Console.ReadLine();

            Console.Write("             3.  email               :   ");
            string email;
            email = Console.ReadLine();

            Console.Write("             4.  DATE OF BIRTH       :   ");
            string dob;
            dob = Console.ReadLine();

            Console.Write("             5.  BLOOD GROUP         :   ");
            string blood;
            blood = Console.ReadLine();

            Console.Write("             6.  GENDER              :   ");
            string gender;
            gender = Console.ReadLine();

            Console.Write("             7.  NATIONALITY         :   ");
            string nationality;
            nationality = Console.ReadLine();

            Console.Write("             8.  RELIGION            :   ");
            string religion;
            religion = Console.ReadLine();
            
            Console.WriteLine(Environment.NewLine);
            

            Console.WriteLine("             9.  ------------        EDUCATION:      ------------  \n ");
            Console.WriteLine("                     DEGREE          :    SSC   ");

            Console.Write("                     INSTITUTION     :       ");
            string inss;
            inss = Console.ReadLine();
            Console.Write("                     BOARD           :       ");
            string boards;
            boards = Console.ReadLine();
            Console.Write("                     PASSING YEAR    :       ");
            string years;
            years = Console.ReadLine();
            Console.Write("                     CGPA            :       ");
            string cgpas;
            cgpas = Console.ReadLine();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("                     DEGREE          :    HSC   ");

            Console.Write("                     INSTITUTION     :       ");
            string insh;
            insh = Console.ReadLine();
            Console.Write("                     BOARD           :       ");
            string boardh;
            boardh = Console.ReadLine();
            Console.Write("                     PASSING YEAR    :       ");
            string yearh;
            yearh = Console.ReadLine();
            Console.Write("                     CGPA            :       ");
            string cgpah;
            cgpah = Console.ReadLine();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("                     DEGREE          :    BSC   ");

            Console.Write("                     INSTITUTION     :       ");
            string insb;
            insb = Console.ReadLine();
            Console.Write("                     BOARD           :       ");
            string boardb;
            boardb = Console.ReadLine();
            Console.Write("                     PASSING YEAR    :       ");
            string yearb;
            yearb = Console.ReadLine();
            Console.Write("                     CGPA            :       ");
            string cgpab;
            cgpab = Console.ReadLine();
            
            Console.WriteLine(Environment.NewLine);


            Console.WriteLine("             10. ------------        EXPERiENCES:      ------------  \n ");

            Console.Write("                     TiTLE           :    ");
            string title;
            title = Console.ReadLine();
            Console.Write("                     DETAiLS         :       ");
            string exp;
            exp = Console.ReadLine();
            Console.Write("                 YEAR OF OCCURANCES  :       ");
            string yoe;
            yoe = Console.ReadLine();
            Console.WriteLine(Environment.NewLine);
            
            Console.Write("                     TiTLE           :    ");
            string title2;
            title2 = Console.ReadLine();
            Console.Write("                     DETAiLS         :       ");
            string exp2;
            exp2 = Console.ReadLine();
            Console.Write("                 YEAR OF OCCURANCES  :       ");
            string yoe2;
            yoe2 = Console.ReadLine();
            Console.WriteLine(Environment.NewLine);
            
            Console.Write("                     TiTLE           :    ");
            string title3;
            title3 = Console.ReadLine();
            Console.Write("                     DETAiLS         :       ");
            string exp3;
            exp3 = Console.ReadLine();
            Console.Write("                     ------>>>       :       ");
            string det3;
            det3 = Console.ReadLine();

            Console.WriteLine(Environment.NewLine);


            Console.Write("             11. SKiLLS              :   ");
            string ski;
            ski = Console.ReadLine();
            Console.Write("                         -------->>>>>   ");
            string skil;
            skil = Console.ReadLine();
            Console.WriteLine(Environment.NewLine);


            Console.Write("             12. NAME OF FATHER      :   ");
            string nof;
            nof = Console.ReadLine();

            Console.Write("             13. -> DESIGNATION      :   ");
            string desf;
            desf = Console.ReadLine();

            Console.Write("             14. NAME of MOTHER      :   ");
            string nom;
            nom = Console.ReadLine();

            Console.Write("             15. -> DESIGNATION      :   ");
            string desm;
            desm = Console.ReadLine();

            Console.Write("             16. PERMANENT ADDRESS   :   ");
            string padd;
            padd = Console.ReadLine();

            Console.Write("             17. PRESENT ADDRESS     :   ");
            string address;
            address = Console.ReadLine();
            Console.WriteLine(Environment.NewLine);


            Console.Write("             18. ACHIEVEMENTS        :   ");
            string ach;
            ach = Console.ReadLine();
            Console.Write("                    ----------->>>>>>>   ");
            string achieve;
            achieve = Console.ReadLine();
            Console.WriteLine(Environment.NewLine);


            Console.Write("             19. INTERESTS IN        :   ");
            string hobby;
            hobby = Console.ReadLine();
            Console.Write("             20. AIM IN LIFE         :   ");
            string goal;
            goal = Console.ReadLine();

//
//  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ CONSOLE OUTPUT SETUP CODELINES ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("---------------------------------------------------------------------------------------------   \n");

            Console.WriteLine(" RESUME OF : " + NAME);
            Console.WriteLine(" ############################################### ");
            Console.WriteLine(Environment.NewLine);
            
            Console.WriteLine(" 1.  NAME                :   "   + NAME          );
            Console.WriteLine(" 2.  DESiGNATION         :   "   + dsg           );
            Console.WriteLine(" 3.  email               :   "   + email         );
            Console.WriteLine(" 4.  DATE OF BiRTH       :   "   + dob           );
            Console.WriteLine(" 5.  BLOODGROUP          :   "   + blood         );
            Console.WriteLine(" 6.  NATiONALiTY         :   "   + nationality   );
            Console.WriteLine(" 7.  GENDER              :   "   + gender        );
            Console.WriteLine(" 8.  RELiGiON            :   "   + religion      );
            Console.WriteLine(Environment.NewLine);
            
            Console.WriteLine(" 9.  ------------        EDUCATiON:      ------------  ");
            Console.Write("     SSC        :   "    + inss +    ",               "   + boards +  "           "  + years + "      "  + cgpas + "\n");
            Console.Write("     HSC        :   "    + insh +    ",                     "   + boardh +  "           "  + yearh + "      "  + cgpah + "\n");
            Console.Write("     BSC.CSE    :   "    + insb +    ",  "   + boardb +    "       "  + yearb +   "     "  + cgpab + "\n");
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine(" 10. ------------        EXPERiENCES:    ------------  ");
            Console.WriteLine("     " + title  + "  ::        ");
            Console.Write("         "     + exp  + "             "  + yoe  + "\n");
            Console.Write("         "     + exp2 + "       "  + yoe2 + "\n");

            Console.WriteLine("     " + title3 + "  ::        ");
            Console.Write("         "     + exp3 +  "\n");
            Console.Write("         "     + det3 +  "\n");
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine(" 11. SKiLLS              :   "   + ski           );
            Console.WriteLine("                             "   + skil          );
            Console.WriteLine(Environment.NewLine);
            
            Console.WriteLine(" 12. NAME OF FATHER      :   "   + nof           );
            Console.WriteLine(" 13. ->  DESiGNATiON     :   "   + desf          );
            Console.WriteLine(" 14. NAME OF MOTHER      :   "   + nom           );
            Console.WriteLine(" 15. ->  DESiGNATiON     :   "   + desm          );
            Console.WriteLine(Environment.NewLine);
            
            Console.WriteLine(" 16. PERMANENT ADDRESS   :   "   + padd          );
            Console.WriteLine(" 17. PRESENT ADDRESS     :   "   + address       );
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine(" 18. ACHiEVEMENTS        :   "   + ach           );
            Console.WriteLine("                             "   + achieve       );
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine(" 19. INTERESTS IN        :   "   + hobby         );
            Console.WriteLine(" 20. AiM IN LiFE         :   "   + goal          );

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>  ######  T H A N K S   F O R    W A T C H I N G   M Y   R E S U M E  ######  <<<<<<<<<<<<<<<<<<<<");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            //Console.WriteLine(Environment.NewLine);
            

            Console.ReadLine();
            Console.ReadKey();

        }
    }
}

