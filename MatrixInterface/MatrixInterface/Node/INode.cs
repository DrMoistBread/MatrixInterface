using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixInterface
{
    public interface INode<T>
    {
        T Value { get; set; }
        int XValue { get; set; }
        int YValue { get; set; }
        Dictionary<string, INode<T>> Pointer { get; }
        void SetPointer(string name, INode<T> node );
    }
}
