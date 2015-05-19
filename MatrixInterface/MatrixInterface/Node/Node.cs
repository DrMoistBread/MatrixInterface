using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixInterface
{
    class Node<T>:INode<T>
    {
      
        public T Value { get; set; }
        public int XValue { get; set; }
        public int YValue { get; set; }
        public Dictionary<string, INode<T>> Pointer { get;  private set; }
        public void SetPointer(String name, INode<T> node)
        {
            Pointer.Add(name,node);
        }

        public Node()
        {
            Pointer = new Dictionary<string, INode<T>>();
        }
    }
}
