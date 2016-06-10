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

            //   matrix.PrintBorder();
            try
            {
                matrix.Insert(6, 1, 5);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            matrix.Insert(5, 3, 2);
            matrix.Insert(3, 2, 1);
            try
            {
                Console.WriteLine(matrix.GetElementFrom(4, 1));
                Console.WriteLine(matrix.GetElementFrom(3, 2));
                Console.WriteLine(matrix.GetElementFrom(5, 3));
                if (matrix.Exists(4,1))
                {

                    Console.WriteLine(matrix.GetElementFrom(3, 2));
                }
                else
                {
                    Console.WriteLine(matrix.Exists(3, 2));
                }
                

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                
            }
            Console.ReadKey();

        }
    }
}
