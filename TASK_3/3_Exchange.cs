using System;

namespace TASK_3_3
{
    class Exchange
    {
        static void Main(string[] args)
        {
            int A, B, SWAP;

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("     --------------- EXCHANGE TWO INTEGERS ----------    ");
            Console.WriteLine("     ------------------------------------------------    ");


            Console.Write(Environment.NewLine + "     DROP 1st INTEGER HERE:	A	=	  ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.Write("     DROP 2nd INTEGER HERE:	B	=	  ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "       >>>USER INPUT WAS :>>      ~ A ~  =   " + A);
            Console.WriteLine("                                  ~ B ~  =   " + B);

            SWAP = A;
            A = B;
            B = SWAP;

            Console.WriteLine(Environment.NewLine + "       >>>ULTIMATE OUTPUT IS :>>  ~ A ~  =   " + A);
            Console.WriteLine("                                  ~ B ~  =   " + B);

            Console.ReadLine();
            Console.ReadKey();

        }

    }
}
