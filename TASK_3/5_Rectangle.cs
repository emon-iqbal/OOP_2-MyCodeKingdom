using System;

namespace TASK_3_5
{
    class Rectangle

    {
        static void Main(string[] args)
        {

            decimal W, H;

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("     --------------- CALCULATE AREA AND PERiMETER OF A RECTANGLE ---------- ");
            Console.WriteLine("     ---------------------------------------------------------------------- ");
            
            Console.WriteLine(Environment.NewLine);
            
            Console.Write("     WiDTH OF A RECTANGLE : >>      ");
            W = Convert.ToDecimal(Console.ReadLine());
            Console.Write("     HEiGHT OF A RECTANGLE: >>      ");
            H = Convert.ToDecimal(Console.ReadLine());
            
            decimal AREA = W * H;
            decimal PER  = 2 * (W + H);

            Console.WriteLine(Environment.NewLine);
            
            Console.WriteLine("     AREA OF THE RECTANGLE       =   "  +  AREA );
            Console.WriteLine("     PERiMETER OF THE RECTANGLE  =   "  +  PER  );

            Console.ReadLine();
            Console.ReadKey();

        }
    }
}
