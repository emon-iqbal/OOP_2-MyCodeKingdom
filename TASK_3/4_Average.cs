using System;

namespace TASK_3
{
    class Average
    {
        static void Main(string[] args)
        {

            int i, n, sum = 0;
            double average;

            Console.Write(Environment.NewLine);
            Console.Write(Environment.NewLine);

            Console.Write("     --------------- READ 5 INTEGERS TO CALCULATE THE AVERAGE ----------      ");
            Console.Write(Environment.NewLine + "           --------------------------------------------------------  ");

            Console.Write(Environment.NewLine);
            Console.Write(Environment.NewLine);

            for (i = 1; i <= 5; i++)
            {
                Console.Write(" PLEASE DROP YOUR INTEGER VALUE HERE : ", i);

                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            average = sum / 5.0;

            Console.Write(Environment.NewLine + " >>>>>>>> THE ULTIMATE AVERAGE FOR SPECIFIED INTEGERS : {1}   <<<<<<<<< ", sum, average);

            Console.ReadLine();
            Console.ReadKey();

        }

    }
}
