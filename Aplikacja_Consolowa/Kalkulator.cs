using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe5_6
{
    class Kalkulator
    {
        public double x;
        public double y;
        public double set_x
        {
            get { return x; }
            set { x = value; }
        }        
        public double set_y
        {
            get { return y; }
            set { y = value; }
        }
        public void wyswietlLiczby()
        {
            Console.WriteLine("X: {0}", this.x);
            Console.WriteLine("Y: {0}", this.y);
        }
        public void dostepneDzialania()
        {
            Console.WriteLine("Dostępne działania:");
            Console.WriteLine("Dodawanie '+'");
            Console.WriteLine("Odejmowanie '-'");
            Console.WriteLine("Mnożenie '*'");
            Console.WriteLine("Dzielenie '/'");
        }
        public void dzialanie(char znak)
        {
            switch (znak)
            {
                case '+':
                    Console.WriteLine("Wynik dodawania: {0}", x + y);
                    break;
                case '-':
                    Console.WriteLine("Wynik odejmowania: {0}", x - y);
                    break;
                case '*':
                    Console.WriteLine("Wynik mnozenia: {0}", x * y);
                    break;
                case '/':
                    if (y == 0)
                        Console.WriteLine("Nie dzielimy przez zero!");
                    else
                        Console.WriteLine("Wynik dzielenia: {0}", x / y);
                    break;
                default:
                    Console.WriteLine("Nieznana opercja");
                    break;
            }

        }
    }
}
