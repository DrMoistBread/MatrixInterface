using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Author: Diogo Cró
*/
namespace MatrixInterface
{
    public interface INode<T>
    {
        T Value { get; set; }
        int XValue { get; set; }
        int YValue { get; set; }
        INode<T> Next { get; set; } 
    }
}
