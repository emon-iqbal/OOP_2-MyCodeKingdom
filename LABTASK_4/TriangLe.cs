using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRiANGLE
{
    class TriangLe
    {
        
        private int x;
        private int y;
        private int z;


        private int Getx()
        {
            Console.Write("     SIDE-1      ::   ");
            return x = Convert.ToInt32(Console.ReadLine());

        }
        
        private int Gety()
        {
            Console.Write("     SIDE-2      ::   ");
            return y = Convert.ToInt32(Console.ReadLine());
        }

        private int Getz()
        {
            Console.Write("     SIDE-3      ::   ");
            return z = Convert.ToInt32(Console.ReadLine()); ;
        }

        
        private void ShowInfo()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("     \n   ## SPECiFiED SiDES FOR THE TRiANGLE >> " + Getx() + " , " + Gety() + " , " + Getz());

        }

        
        
        private void TestTriangLe()
        {


            if (x != y && x != z && y != z)
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("  >>>>>>>>>>>>  THIS IS A SCALANE TRiANGLE [[all the three sides contain different/random values ]] ");
            }


            else if (x == y && y == z)
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("  >>>>>>>>>>>>  THIS IS AN EQUiLATERAL TRiANGLE [[ all the specified sides are equal ]] ");
            }
            

            else
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("  >>>>>>>>>>>>  THIS IS AN iSOSCALES TRiANGLE [[ any two specified sides are equal ]]  ");
            }

        }


        
        static void Main(string[] args)
        {
            TriangLe E = new TriangLe();

            E.ShowInfo();
            E.TestTriangLe();
            
            Console.ReadLine();
            Console.ReadKey();

        }
    }
}
