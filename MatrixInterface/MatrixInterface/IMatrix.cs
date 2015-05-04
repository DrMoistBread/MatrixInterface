using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixInterface
{
    public interface IMatrix<T>
    {
        
        INode<T> Node { get; set; }
        INode<T> First { get; set; }
        void Insert(T value);
        void Remove(T value); // removes all the value values in the Matrix
        void Remove(int x, int y); //removes the node on the cordinates (x,y)
        T GetValueFrom(int x, int y); // gets the value from in the (x,y position)
        bool Exists(int x, int y);
        bool HasValue(T value);

    }
}

