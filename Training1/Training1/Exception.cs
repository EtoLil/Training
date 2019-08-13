using System;
using System.Collections.Generic;
using System.Text;

namespace Training1
{
    class RectangleException : Exception
    {
        public RectangleException(string message)
            : base(message) { }
    }
    #region class ComplexNumberException for ComplexNumber
    class ComplexNumberException : Exception
    {
        public ComplexNumberException(string message)
            : base(message) { }
    }
    #endregion
    class CircleException : Exception
    {
        public CircleException(string message)
            : base(message) { }
    }
}
