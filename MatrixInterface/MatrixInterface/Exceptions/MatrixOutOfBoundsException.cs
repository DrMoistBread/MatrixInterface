using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixInterface.Exceptions
{
    class MatrixOutOfBoundsException:Exception
    {

        public MatrixOutOfBoundsException()
        {
        }

        public MatrixOutOfBoundsException(string message):base(message)
        {
        }

    }
}
