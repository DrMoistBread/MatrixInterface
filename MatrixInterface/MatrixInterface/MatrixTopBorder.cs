using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixInterface.Exceptions;
using MatrixInterface.Node;

namespace MatrixInterface
{
    public class MatrixTopBorder<T> : IMatrix<T>
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

           for (int i = 1; i <= width; i++)
           {
               INode<T> node = new Node<T>();
               node.YValue = -1;
               node.XValue = i;
               aux.SetPointer("right",node);
               aux.SetPointer("bottom", new NullNode<T>());
               aux = node;
           }

           INode<T> endNode = new NullNode<T>();
           endNode.XValue = -1;
           endNode.YValue = -1;
           aux.SetPointer("bottom", new NullNode<T>());
           aux.SetPointer("right",endNode);
       }
       
       //creates a mew copy of the Matrix
       public MatrixTopBorder(IMatrix<T> aMatrix){
           
       }


      

        public void Insert(int x, int y, T element)
        {
            INode<T> aux = First;
            while (aux.GetType() != typeof(NullNode<T>))
            {
                if (aux.XValue == x)
                    break;
                aux = aux.Pointer["right"];
            }

            if (aux.GetType() == typeof(NullNode<T>)) 
                throw new MatrixOutOfBoundsException("The x inserted is greater than the width of the matrix");

            if(aux.Pointer.ContainsKey("bottom"))
                while (aux.Pointer["bottom"].GetType() != typeof(NullNode<T>))
                {
                    if (aux.Pointer["bottom"].YValue > y)
                        break;
                    aux = aux.Pointer["bottom"];
                }
            
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
            if (!Exists(x, y)) return;
          
                INode<T> aux = First;
                while (aux.GetType() != typeof(NullNode<T>))
                {
                    if (aux.XValue == x)
                        break;
                    aux = aux.Pointer["right"];
                }

                if (aux.GetType() == typeof(NullNode<T>))
                    throw new MatrixOutOfBoundsException("The x inserted is greater than the width of the matrix");

                if (aux.Pointer.ContainsKey("bottom"))
                    while (aux.Pointer["bottom"].GetType() != typeof(NullNode<T>) && aux.Pointer["bottom"].YValue <= y)
                    {
                        if (aux.Pointer["bottom"].YValue == y)
                        {
                            aux.Pointer["bottom"] = aux.Pointer["bottom"].Pointer["bottom"];
                            break;
                        }
                        aux = aux.Pointer["bottom"];

                    }
           
        }

        public T GetElementFrom(int x, int y)
        {
            INode<T> aux = First;
            while (aux.GetType() != typeof(NullNode<T>))
            {
                if (aux.XValue == x)
                    break;
                aux = aux.Pointer["right"];
            }

            if (aux.GetType() == typeof(NullNode<T>))
                throw new MatrixOutOfBoundsException("The x inserted is greater than the width of the matrix");

            if (aux.Pointer.ContainsKey("bottom"))
                while (aux.GetType() != typeof(NullNode<T>) && aux.YValue <= y)
                {
                    if (aux.YValue == y)
                        return aux.Value;
                    aux = aux.Pointer["bottom"];

                }
            throw new ElementNotFoundException(String.Format("There is no element in position ({0},{1})",x,y));
        }

        public bool Exists(int x, int y)
        {
            INode<T> aux = First;
            while (aux.GetType() != typeof(NullNode<T>))
            {
                if (aux.XValue == x)
                    break;
                aux = aux.Pointer["right"];
            }

            if (aux.GetType() == typeof(NullNode<T>))
                throw new MatrixOutOfBoundsException("The x inserted is greater than the width of the matrix");

            if (aux.Pointer.ContainsKey("bottom"))
                while (aux.GetType() != typeof(NullNode<T>) && aux.YValue <= y)
                {
                    if (aux.YValue == y)
                        return true;
                    aux = aux.Pointer["bottom"];

                }
            return false;
        }

        public bool Exists(T element)
        {
            throw new NotImplementedException();
        }

        public void Expand(int slots)
        {

            if (First.GetType() != typeof (NullNode<T>))
            {
                INode<T> auxNod = First;
                while (auxNod.Pointer["right"].GetType() != typeof (NullNode<T>))
                    auxNod = auxNod.Pointer["right"];

                INode<T> nullNode = auxNod.Pointer["right"];
              
                for (int i = 1; i <=slots; i++)
                {
                    INode<T> node = new Node<T>();
                    node.YValue = -1;
                    node.XValue = i+Length;
                    node.SetPointer("bottom", new NullNode<T>());
                    auxNod.SetPointer("right", node);
                    auxNod = node;
                }
                auxNod.SetPointer("right",nullNode);
                Length += slots;
            }
        }

        public void Expand(int x, int y)
        {
           Expand(x);
        }

        public void PrintBorder()
        {
            INode<T> aux = First;

            for (int i =0; i<Length; i++)
            {
                Console.WriteLine("x = " + aux.XValue + " y = " + aux.YValue);

                foreach (var t in aux.Pointer)
                {
                    Console.Write(t.Key+" ");
                    Console.Write(t.Value.XValue); Console.WriteLine("");
                }
                aux = aux.Pointer["right"];

                Console.ReadKey();
            }
        }

        public void PrintMatrix()
        {
            int maxHeight = -1;

            for (INode<T> auxX = First;
                auxX.GetType() != typeof (NullNode<T>);
                auxX = auxX.Pointer["right"])
            {
                 INode<T> auxY = auxX;
                while (auxY.Pointer["bottom"].GetType() != typeof (NullNode<T>))
                {
                    auxY = auxY.Pointer["bottom"];
                }

                if (auxY.YValue > maxHeight)
                    maxHeight = auxY.YValue;
            }

            for (int y = 0; y <= maxHeight; y++)
            {
                for (int x = 0; x <=Length ; x++)
                {
                    if (Exists(x,y))
                        Console.Write(GetElementFrom(x, y) + "\t");
                    else
                        Console.Write("0\t");
                }
                Console.WriteLine();
            }

    }
    }
}
