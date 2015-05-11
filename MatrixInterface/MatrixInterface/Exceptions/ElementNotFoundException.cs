using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixInterface.Exceptions
{
    class ElementNotFoundException:Exception
    {
    
    public ElementNotFoundException()
    {
    }

    public ElementNotFoundException(string message): base(message)
    {
    }

    }
}
