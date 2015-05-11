using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixInterface
{
    public interface IMatrix<T>
    {
        
        //INode<T> Node { get; set; } 
        INode<T> First { get; set; }
        int Length { get; }
        void Insert(int x, int y, T element); // inserts element value in the (x,y) position 
        void Insert(T element); // iserts the elment in the first available slot
        void Remove(T element); // removes all the value values in the Matrix
        void Remove(int x, int y); // removes the node on the cordinates (x,y)
        T GetElementFrom(int x, int y); // gets the value from in the (x,y) position
        bool Exists(int x, int y); // verifies is the is an element in the (x,y) position
        bool Exists(T element); // verifies is the element exist in the matrix
        void Expand(int slots);// expands the matrix in i slots
        void Expand(int x, int y);// expands x slot on the X axis and y slot on Y axis
        void PrintBorder();
        void PrintMatrix();

    }
}

