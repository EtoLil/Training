using System;
using System.Collections.Generic;
using System.Text;

namespace Training1
{
    class ComplexNumber
    {
        #region member field
        private double real;
        private double imaginary;
        #endregion

        #region Constructor without param
        public ComplexNumber()
        {
            real = 0.0;
            imaginary = 0.0;
        }
        #endregion
        #region Constructor with param
        public ComplexNumber(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        #endregion
        #region Overriding operator *
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.real * c2.real - c1.imaginary * c2.imaginary, c1.real * c2.imaginary + c1.imaginary * c2.real);
        }
        #endregion
        #region Overriding operator /
        public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
        {
            if (c2.real == 0 && c2.imaginary == 0)
                throw new ComplexNumberException("Divide by zero");
            double div = c2.real * c2.real + c2.imaginary * c2.imaginary;
            return new ComplexNumber(((c1.real * c2.real + c1.imaginary * c2.imaginary) / div),
                    ((c1.imaginary * c2.real - c1.real * c2.imaginary) / div));
        }
        #endregion
        #region Method ReadComplex(read a complex number from the console)
        public void ReadComplex()
        {
            Console.WriteLine("Input real part!");
            real = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input imaginary part!");
            imaginary = Convert.ToDouble(Console.ReadLine());
        }
        #endregion
        #region Method GetInfo(print a complex number to the console)
        public void GetInfo()
        {
            Console.Write($"({Math.Round(real, 2)} + {Math.Round(imaginary, 2)}i)");
        }
        #endregion
        #region Method Operation(print to the console result(c3) ,method does not calculate )
        public static void Operation(string op, ComplexNumber c1, ComplexNumber c2, ComplexNumber c3)
        {
            c1.GetInfo();
            Console.Write(op);
            c2.GetInfo();
            Console.Write("=");
            c3.GetInfo();
            Console.WriteLine();
        }
        #endregion
    }
}
