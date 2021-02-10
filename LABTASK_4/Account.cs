using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACCOUNT
{
    class Account
    {

        private string  accName;
        private string  accID;
        private int     accBaLance;

        
        private string GetaccName()
        {
            Console.Write("     ACCOUNT HOLDER NAME ::   ");
            return accName = Console.ReadLine();

        }
        private string GetaccID()
        {
            Console.Write("     ACCOUNT ID          ::   ");
            return accID = Console.ReadLine();
        }

        private int GetaccBaLance()
        {
            Console.Write("     ACCOUNT BALANCE     ::   ");
            return accBaLance = Convert.ToInt32(Console.ReadLine());
        }


        //---------------------------------------------------------------------------------------------------

        
        private void ShowACCOUNTInfo()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(" \n    ## SPECiFiED ACCOUNT HOLDER NAME        >>           "  + GetaccName() + " \n     ## SPECiFiED ACCOUNT HOLDER ID No.      >>          " + GetaccID() + " \n      ## SPECiFiED     ACCOUNT     BALANCE    >>   TK.   " + GetaccBaLance() + "\n");
           
        }

        
        //---------------------------------------------------------------------------------------------------

        
        private void Deposit()
        {
            int amount;
            Console.WriteLine(Environment.NewLine);

            Console.Write("  ## PLEASE WRITE THE AMOUNT YOU WANT TO DEPOSIT   >>>>>  TK.    ");
            amount = Convert.ToInt32(Console.ReadLine());
           
        
            if (amount >= 10000 && amount <= 1000000)
            {
                Console.WriteLine(Environment.NewLine);
                accBaLance = amount + accBaLance;
                
                Console.WriteLine("  >>>>>>>>>>>>>>>>>>>>>>.......... ........... .......>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> ");
                Console.WriteLine("  >>>>>>>>>>>>  CONGRATS !! YOUR EXPECTED AMOUNT IS SUCCESSFULLY DEPOSITED <<<<<<<<<<<<<<< ");
                Console.WriteLine(Environment.NewLine);
                
                Console.WriteLine("  --------------------------------------------------------------------------------------- ");
                Console.WriteLine("                      YOUR CURRENT BALANCE ====>>>  TK...    " + accBaLance);
                Console.WriteLine("  --------------------------------------------------------------------------------------- ");
                
            }
            else
            {
                Console.WriteLine(Environment.NewLine);
                
                Console.Write("  >>>>>>>>>>>>  OOOpppSss....... *** PLEASE TRY ONE LAST TiME *** ");
                Console.Write(" \n  [[  YOU MUST NEED TO DEPOSIT AT LEAST AN AMOUNT OF TK. 10000 (TEN THOUSANDS) UPTO TK. 1000000 (TEN LAKHS)  ]] \n ");
                Console.WriteLine(Environment.NewLine);
                
                
                Console.Write("  ## LAST TRY ----------->>>  PLEASE WRITE THE AMOUNT YOU WANT TO DEPOSIT   >>>>>  TK.    ");
                amount = Convert.ToInt32(Console.ReadLine());
                accBaLance = amount + accBaLance;
                Console.WriteLine(Environment.NewLine);
                
                Console.WriteLine("  >>>>>>>>>>>>>>>>>>>>>>.......... ........... .......>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> ");
                Console.WriteLine("  >>>>>>>>>>>>  CONGRATS !! YOUR EXPECTED AMOUNT IS SUCCESSFULLY DEPOSITED <<<<<<<<<<<<<<< ");
                Console.WriteLine(Environment.NewLine);

                Console.WriteLine("  --------------------------------------------------------------------------------------- ");
                Console.WriteLine("                      YOUR CURRENT BALANCE ====>>>  TK...    " + accBaLance);
                Console.WriteLine("  --------------------------------------------------------------------------------------- ");


            }
        }


        //---------------------------------------------------------------------------------------------------

        
        private void WithDraw()
        {
            int amount;
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            
            Console.Write("  ## PLEASE WRITE THE AMOUNT YOU WANT TO WiTHDRAW FROM YOUR ACCOUNT   >>>>>  TK.    ");
            amount = Convert.ToInt32(Console.ReadLine());
            
            
            if (amount <= accBaLance && amount >= 0)
            {

                Console.WriteLine(Environment.NewLine);
                amount = accBaLance - amount;

                Console.WriteLine("  >>>>>>>>>>>>>>>>>>>>>>>>>>>>>> ............ ............. ......... >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> "); 
                Console.WriteLine("  >>>>>>>>>>>>  HERE YOU GO !! YOUR EXPECTED AMOUNT IS SUCCESSFULLY  W i T H D R A W N <<<<<<<<<<<<<<< ");
                Console.WriteLine(Environment.NewLine);

                Console.WriteLine("  _________________________________________________________________________________________________________ ");
                Console.WriteLine("     !! REGARDS !!  .............   YOUR ULTIMATE ACCOUNT BALANCE STANDS WITH >>>>  # TK.    " + amount);
                Console.WriteLine("  _________________________________________________________________________________________________________ ");

            }
            else
            {
                Console.WriteLine(Environment.NewLine);

                Console.WriteLine("  >>>>>>>>>>>>  OOOpppSss....... i N V A L i D  W i T H D R A W   *** PLEASE TRY ONE LAST TiME *** ");
                Console.WriteLine(" \n  [[  YOU MUST NEED TO WiTHDRAW AT LEAST AN AMOUNT OF TK. 0   << OR >>  WiTHiN AN AMOUNT OF YOUR CURRENT BALANCE ]] ... \n ");
                Console.Write(" \n  YOUR CURRENT BALANCE >>>> TK.   " + accBaLance);
                Console.WriteLine(Environment.NewLine);

                Console.Write("  ## LAST TRY ----------->>>  PLEASE WRITE THE AMOUNT YOU WANT TO WiTHDRAW FROM YOUR ACCOUNT   >>>>>  TK.    ");
                amount = Convert.ToInt32(Console.ReadLine());
                amount = accBaLance - amount;
                Console.WriteLine(Environment.NewLine);

                Console.WriteLine("  >>>>>>>>>>>>>>>>>>>>>>>>>>>>>> ............ ............. ......... >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> ");
                Console.WriteLine("  >>>>>>>>>>>>  HERE YOU GO !! YOUR EXPECTED AMOUNT IS SUCCESSFULLY  W i T H D R A W N <<<<<<<<<<<<<< ");
                Console.WriteLine(Environment.NewLine);

                Console.WriteLine("  _________________________________________________________________________________________________________ ");
                Console.WriteLine("     !! REGARDS !!  .............   YOUR ULTIMATE ACCOUNT BALANCE STANDS WITH >>>>  # TK.    " + amount);
                Console.WriteLine("  _________________________________________________________________________________________________________ ");

            }

        }


        //---------------------------------------------------------------------------------------------------


        static void Main(string[] args)
        {
            Account DDTT = new Account();

            DDTT.ShowACCOUNTInfo();
            DDTT.Deposit();
            DDTT.WithDraw();
            

            Console.ReadLine();
            Console.ReadKey();
        
        }
    }
}
