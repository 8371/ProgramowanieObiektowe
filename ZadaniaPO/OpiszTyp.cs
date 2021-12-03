using System;

namespace Zadania_PO
{
    class Program
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
        static void Main(string[] args)
        {
            Console.WriteLine(OpiszTyp());
            Console.WriteLine(OpiszTyp(2));
            Console.WriteLine(OpiszTyp(2, 2));
            Console.WriteLine(OpiszTyp(2.3 , 9.100));
            Console.WriteLine(OpiszTyp("Ala ma kota"));
        }
    }
}
