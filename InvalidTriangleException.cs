using System;
using System.Collections.Generic;
using System.Text;

namespace CM.Extentions
{
    public class InvalidTriangleException : Exception
    {
        public InvalidTriangleException()
        {
        }

        public InvalidTriangleException(String message) :
            base(message)
        {
            
        }

    }
}
