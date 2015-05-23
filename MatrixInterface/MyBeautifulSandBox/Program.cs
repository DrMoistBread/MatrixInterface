using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixInterface;

namespace MyBeautifulSandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            IMatrix<int> matrix = new MatrixTopBorder<int>(5);
            
            matrix.Insert(0, 4, 3);
            matrix.Insert(0, 4, 6);
            matrix.Insert(1, 1, 4);
            matrix.Insert(2, 2, 2);
            matrix.Insert(2, 4, 210);
            matrix.Insert(3, 9, 4);
            matrix.Insert(2, 0, 7);
            matrix.Insert(3, 3, 44);
            matrix.Insert(5, 4, 25);
            matrix.Insert(4, 2, 245);
            matrix.Insert(3, 4, 45);
            matrix.Insert(5, 0, 25);
            matrix.Insert(5, 100, 25);
            matrix.PrintMatrix();
            Console.WriteLine("\n%%%%%%%%%%%%%%%%%% PIXOTAS %%%%%%%%%%%%%%%%%%\n");
            matrix.Expand(2);
          //  matrix.PrintBorder();
            matrix.Remove(2,4);
            matrix.Remove(3,3);
            matrix.Remove(5, 4);
            matrix.Remove(4, 2);
            matrix.Remove(3, 4);
            matrix.Remove(5, 0);
            matrix.PrintMatrix();
            matrix.Expand(2);
            matrix.PrintMatrix();
            Console.ReadKey();

        }
    }
}
