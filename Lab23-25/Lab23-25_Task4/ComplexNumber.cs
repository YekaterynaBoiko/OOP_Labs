using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_25_Task4
{
    public class ComplexNumber
    {
        public double A { get; set; }
        public double B {get; set; }

        public ComplexNumber(double a, double b)
        {
            A = a; 
            B = b;
        }

        public static ComplexNumber operator +(ComplexNumber x, ComplexNumber y)
            => new ComplexNumber(x.A + y.A, x.B + y.B);
        public static ComplexNumber operator -(ComplexNumber x, ComplexNumber y)
            => new ComplexNumber(x.A - y.A, x.B - y.B);

        public static ComplexNumber operator *(ComplexNumber x, ComplexNumber y)
            => new ComplexNumber(x.A * y.A - x.B * y.B, x.A * y.B + x.B * y.A);

        public static ComplexNumber operator /(ComplexNumber x, ComplexNumber y)
        {
            double res = y.A * y.A + y.B * y.B;
            return new ComplexNumber((x.A * y.A + x.B * y.B) / res, (x.B * y.A - x.A * y.B) / res);
        }


        public static ComplexNumber operator !(ComplexNumber x)
            => new ComplexNumber(-x.A, -x.B);

        public static bool operator ==(ComplexNumber x, ComplexNumber y)
            => x.A == y.A && x.B == y.B;

        public static bool operator !=(ComplexNumber x, ComplexNumber y)
            => !(x.A == y.A && x.B == y.B);
    }
}
