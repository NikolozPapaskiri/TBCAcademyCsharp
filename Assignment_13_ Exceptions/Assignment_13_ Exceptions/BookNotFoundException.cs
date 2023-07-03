using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13__Exceptions
{
    public class BookNotFoundException : Exception
    {
        public BookNotFoundException()
        {
        }

        public BookNotFoundException(string message)
            : base(message)
        {
        }

        public BookNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
