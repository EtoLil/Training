using System;

namespace Training1
{
    #region class ComplexNumberException for ComplexNumber

    internal class ComplexNumberException : Exception
    {
        public ComplexNumberException(string message)
            : base(message)
        {
        }
    }
    #endregion
}
