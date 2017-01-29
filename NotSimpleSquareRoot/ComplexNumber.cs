using System;
using System.Runtime.Remoting.Contexts;

namespace NotSimpleSquareRoot
{
    class ComplexNumber
    {
        public ComplexNumber (double r, double i)
        {
            Rational = r;
            Imaginary = i;
        }

        public ComplexNumber (double cosX,double sinX, double length)
        {
            Rational = Math.Acos(cosX) * length;
            Imaginary = Math.Asin(sinX) * length;
        }

        public ComplexNumber[] Sqrt (double error = .000001)
        {
            ComplexNumber result1 = new ComplexNumber(Math.Cos(Rational / (Magnitude * 2)), Math.Sin(Imaginary / (Magnitude * 2)), Math.Sqrt(Magnitude));
            ComplexNumber result2 = new ComplexNumber(-result1.Rational,-result1.Imaginary);
            return new[] { result1, result2 };
        }

        /*public static ComplexNumber NumSqrt (double number, double error = .000001)
        {
            bool negative = false;
            if (number < 0)
            {
                number = -number;
                negative = true;
            }
            double x = 1;
            while (true)
            {
                double value = x * x;
                if (Math.Abs(value - number) <= error)
                    return negative ? new ComplexNumber(0,value) : new ComplexNumber(value,0);

                x = x / 2 + number / (2 * x);
            }
        }*/

        public override string ToString()
        {
            return Rational + " + " + Imaginary + "i";
        }

        public double Rational;
        public double Imaginary;
        public double Magnitude => Rational * Rational + Imaginary * Imaginary;
        public double CosX => Math.Cos(Rational / Magnitude);
        public double SinX => Math.Sin(Imaginary / Magnitude);
    }
}