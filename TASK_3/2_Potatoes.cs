using System;

namespace TASK_3
{
    class Potatoes
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("     --------------- SHOW THE TOTAL COST OF 1 kg POTATOES   [[iNCLUDiNG TAX]] ----------    ");
            Console.WriteLine("     -----------------------------------------------------------------------------------    ");

            Console.Write(Environment.NewLine + "     COST OF 1 kg PRODUCT            =       ");
            int P = Convert.ToInt32(Console.ReadLine());

            Console.Write("     WEiGHTS OF PRODUCT TO PURCHASE  =       ");
            decimal M = Convert.ToDecimal(Console.ReadLine());

            Console.Write("     TAX RATE OF 1 KiLOGRAM PRODUCT  =       ");
            double T = Convert.ToDouble(Console.ReadLine());


            if (P <= 0)
            {
                Console.WriteLine(Environment.NewLine);
                Console.Write(Environment.NewLine + "           COST OF PRODUCTS CANNOT CONTAIN NEGATIVE VALUES OR  >> 0 << ");
            }
            else
            {
                Console.WriteLine(Environment.NewLine);
                Console.Write(Environment.NewLine + "   #   PRiCE OF 1 kg POTATO      =  TK. " + P + "  [currency for BANGLADESH in Taka]  ");
            }
            
            if (M <= 0)
            {
                Console.WriteLine(Environment.NewLine);
                Console.Write(Environment.NewLine + "       WEiGHTS OF RESPECTIVE PRODUCTS MUST BE GREATER THAN 0 ");
            }
            else
            {
                Console.Write(Environment.NewLine + "   #   TOTAL WEiGHT TO PURCHASE  =      " + M + "   KiLOGRAM  ");
            }

            if (T <= 0)
            {
                Console.WriteLine(Environment.NewLine);
                Console.Write(Environment.NewLine + "       TAX OF RESPECTIVE PRODUCT MUST BE IN PERCENT UNIT AND GREATER THAN 0");
            }
            else
            {
                Console.Write(Environment.NewLine + "   #   TAX OF 1 KiLOGRAM PRODUCT  =      " + T + "  %  ");
            }

            decimal COST;

            P = Convert.ToInt32(P * M);
            M = Convert.ToInt32(P * T);
            COST = Convert.ToDecimal(M / 100);
           
            COST = Convert.ToDecimal(COST + P);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine + "   ------------------------------------------------------------------------------------------------ ");
            Console.WriteLine(Environment.NewLine + " >>>>    U L T I M A T E  C O S T  O F  P U R C H A S E D  P O T A TO E S  =  TK.       " + COST);
            Console.WriteLine(Environment.NewLine + "   ------------------------------------------------------------------------------------------------ ");
            
            Console.ReadLine();
            Console.ReadKey();

        }
    }
}
