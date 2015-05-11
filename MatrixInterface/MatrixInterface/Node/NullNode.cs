using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixInterface.Node
{
    class NullNode<T>:INode<T>
    {
        
        public T Value { get; set; }
        public int XValue { get; set; }
        public int YValue { get; set; }
        public Dictionary<string, INode<T>> Pointer { get; private set; }
        public void SetPointer(string name, INode<T> node)
        {
            
        }
    }
}
