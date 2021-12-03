using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_PO
{
    class opiszTyp
    {
        static string OpiszTyp()
        {
            return "Pusta metoda";
        }
        static string OpiszTyp(int a)
        {
            return "Wartość int: " + Convert.ToString(a);
        }
        static string OpiszTyp(double a)
        {
            return "Wartość double: " + Convert.ToString(a);
        }
        static string OpiszTyp(string a)
        {
            return "Wartość string: " + Convert.ToString(a);
        }
        static string OpiszTyp(int a, int b)
        {
            return "Podwójny int: " + Convert.ToString(a) + ", " + Convert.ToString(b);
        }
        static string OpiszTyp(double a, double b)
        {
            return "Podwójny double: " + Convert.ToString(a) + ", " + Convert.ToString(b);
        }
    }
}
