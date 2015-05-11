using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixInterface.Exceptions;
using MatrixInterface.Node;

namespace MatrixInterface
{
    public class MatrixTopBorder<T>:IMatrix<T>
    {

        public int Length { get; private set; }

       public INode<T> First { get; set; }
    
       public MatrixTopBorder(){
           First=null;
       }
       
       //dimension of the Matrix
       public MatrixTopBorder(int width)
       {
           Length = width;
           INode<T> aux= new Node<T>();
           aux.YValue = -1;
           aux.XValue = 0;
           First = aux;

           for (int i = 1; i < width+1; i++)
           {
               INode<T> node = new Node<T>();
               node.YValue = -1;
               node.XValue = i;
               aux.SetPointer("right",node);
               aux.SetPointer("bottom", new NullNode<T>());
               aux = node;
           }
       }
       
       //creates a mew copy of the Matrix
       public MatrixTopBorder(IMatrix<T> aMatrix){
           
       }


      

        public void Insert(int x, int y, T element)
        {
            INode<T> aux = First;
            while (aux!=null)
            {
                if (aux.XValue == x)
                    break;
                aux = aux.Pointer["right"];
            }

            if (aux.Pointer["bottom"].GetType() != typeof(NullNode<T>)) 
                throw new MatrixOutOfBoundsException("The x inserted is greater than the width of the matrix");

            if(aux.Pointer.ContainsKey("bottom"))
                while (aux.Pointer["bottom"].GetType() != typeof(NullNode<T>))
                {
                    if (aux.Pointer["bottom"].YValue < y)
                        break;

                }
            

            if (aux == null) throw new MatrixOutOfBoundsException("The y inserted is greater than the length of the matrix");

            INode<T> newNode = new Node<T>();
            newNode.XValue = x;
            newNode.YValue = y;
            newNode.Value = element;
            newNode.SetPointer("bottom",aux.Pointer["bottom"]) ;
            aux.Pointer["bottom"] = newNode;



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
            INode<T> aux = First;
            while (aux != null)
            {
                if (aux.XValue == x)
                    break;
                aux = aux.Pointer["right"];
            }

            if (aux.Pointer["bottom"].GetType() == null)
                throw new MatrixOutOfBoundsException("The x inserted is greater than the width of the matrix");

            if (aux.Pointer.ContainsKey("bottom"))
                while (aux.GetType() != typeof(NullNode<T>) && aux.YValue <= y)
                {
                    aux = aux.Pointer["pointer"];
                }


            if (aux.GetType() == typeof(NullNode<T>)) throw new MatrixOutOfBoundsException("The y inserted is greater than the length of the matrix");

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

        public void PrintBorder()
        {
            INode<T> aux = First;

            for (int i =0; i<Length; i++)
            {
                Console.WriteLine("x = " + aux.XValue + " y = " + aux.YValue);

                foreach (var t in aux.Pointer)
                {
                    Console.WriteLine(t.Key+" ");
                }
                aux = aux.Pointer["right"];

                Console.ReadKey();
            }
        }

        public void PrintMatrix()
        {
           
        }
    }
}
