using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixInterface
{
    public class MatrixTopBorder<T>:IMatrix<T>
    {
        
       public Matrix(){
           First=0;
       }
       
       //dimension of the Matrix
       public Matrix(int x, int y){
           
       }
       
       //creates a mew copy of the Matrix
       public Matrix(IMatrix aMatrix){
           
       }
    }
}
