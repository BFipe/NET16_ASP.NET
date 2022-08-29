using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_12
{
    internal class NullOrWhiteSpaceException : Exception
    {
        public NullOrWhiteSpaceException(string value) : base($"Incorrect imput (\"{value}\")! Your data is empty!")
        {

        }
    }
}
