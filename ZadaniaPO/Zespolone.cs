using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_PO
{
    class Zespolone
    {
        public double re;
        public double im;
        public Zespolone(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        public static Zespolone operator +(Zespolone a, Zespolone b)
            => new Zespolone(a.re + b.re, a.im + b.im);
        public static Zespolone operator -(Zespolone a, Zespolone b)
            => new Zespolone(a.re - b.re, a.im - b.im);
        public static Zespolone operator *(Zespolone a, Zespolone b)
        {
            double re = a.re * b.re - a.im * b.im;
            double im = a.re * b.im + a.im * b.re;
            return new Zespolone(re, im);
        }
        public static Zespolone operator /(Zespolone a, Zespolone b)
        {
            double w = b.re * b.re + b.im * b.im;
            if (w > 0)
            {
                double re = (a.re * b.re + a.im * b.im) / w;
                double im = (b.re * a.im - a.re * b.im) / w;

                return new Zespolone(re, im);
            }
            else
                throw new DivideByZeroException();
        }
        public override string ToString()
        {
            return $"({this.re}, {this.im}j)";
        }
    }
}
