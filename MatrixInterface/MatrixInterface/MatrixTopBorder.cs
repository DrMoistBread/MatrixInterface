using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixInterface
{
    public class MatrixTopBorder<T>:IMatrix<T>
    {
        
       public MatrixTopBorder(){
           First=null;
       }
       
       //dimension of the Matrix
       public MatrixTopBorder(int x, int y){
           
       }
       
       //creates a mew copy of the Matrix
       public MatrixTopBorder(IMatrix<T> aMatrix){
           
       }

        public INode<T> First { get; set; }

        public void Insert(int x, int y, T element)
        {
            throw new NotImplementedException();
        }

        public void Insert(T element)
        {
            throw new NotImplementedException();
        }

        public void Remove(T element)
        {
            throw new NotImplementedException();
        }

        public void Remove(int x, int y)
        {
            throw new NotImplementedException();
        }

        public T GetElementFrom(int x, int y)
        {
            throw new NotImplementedException();
        }

        public bool Exists(int x, int y)
        {
            throw new NotImplementedException();
        }

        public bool Exists(T element)
        {
            throw new NotImplementedException();
        }

        public void Expand(int slots)
        {
            throw new NotImplementedException();
        }

        public void Expand(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
