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
            IMatrix<int> matrix = new MatrixTopBorder<int>(6);
            matrix.PrintBorder();

            try
            {
                matrix.Insert(0,7,4);
            }
            
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
