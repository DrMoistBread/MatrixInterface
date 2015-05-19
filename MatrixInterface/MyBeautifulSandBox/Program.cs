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
            matrix.Insert(4, 2, 5);
            matrix.Insert(5, 3, 2);
            matrix.Insert(3, 2, 1);
            try
            {
                Console.WriteLine(matrix.GetElementFrom(4, 2));
                Console.WriteLine(matrix.GetElementFrom(3, 2));
                Console.WriteLine(matrix.GetElementFrom(5, 3));
                if (matrix.Exists(2,1))
                {

                    Console.WriteLine(matrix.GetElementFrom(2, 1));
                }
                else
                {
                    Console.WriteLine(matrix.Exists(2, 1));
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
