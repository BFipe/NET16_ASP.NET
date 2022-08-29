using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_12
{
    internal class ZeroOrBelowZeroException : Exception
    {
        public ZeroOrBelowZeroException(double value) : base($"Incorrect imput ({value})! Your value must be > 0")
        {

        }
    }
}
