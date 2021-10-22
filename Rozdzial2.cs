using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Zadanie 2.1 uncoment ctrl-K + ctrl-U // ctrl-c
            //double F, C;
            //Console.WriteLine("Podaj temp. w stopniach Celsjusza: ");
            //C = double.Parse(Console.ReadLine());
            //F = 32 + (9.0 / 5) * C;
            //Console.WriteLine(F);
            //Console.ReadKey();
            // Zadanie 2.2
            //double A, B, C1, delta, x1, x2;
            //Console.WriteLine("Podaj wspolczynniki a, b, c: ");
            //A = double.Parse(Console.ReadLine());
            //B = double.Parse(Console.ReadLine());
            //C1 = double.Parse(Console.ReadLine());
            //delta = B * B - 4 * A * C1;
            //x1 = x2 = 0;
            //if (A == 0)
            //{
            //    Console.WriteLine("Nie dzielimy przez zero!");
            //}
            //else
            //{
            //    if (delta == 0)
            //    {
            //        x1 = x2 = -B / (2 * A);
            //    }
            //    if (delta > 0)
            //    {
            //        x1 = (-B + Math.Sqrt(delta)) / (2 * A);
            //        x2 = (-B - Math.Sqrt(delta)) / (2 * A);
            //    }
            //    if (delta < 0)
            //        Console.WriteLine("Brak rozwiązań");
            //    if (delta >= 0)
            //        Console.WriteLine("Wynik x1={0}, x2={1}", x1, x2);
            //    Console.ReadKey();
            //}
            // Zadanie 2.3
            //Console.WriteLine("Podaj wage w kilogramach, podaj wzrost w metrach");
            //double waga, wzrost;
            //waga = double.Parse(Console.ReadLine());
            //wzrost = double.Parse(Console.ReadLine());
            //Console.WriteLine("BMI={0}", waga / (wzrost * wzrost));
            // Zadanie 2.4
            //int x = 100;
            //Console.WriteLine(++x * 2); // wyświetli się 202 (a)
            // Zadanie 2.5
            //int x = 2, y = 3;
            //x *= y * 2;
            //Console.WriteLine("x={0}", x); // zmienna x=12, (d)
            // Zadanie 2.6
            //int x, y = 4; //x=0, y=4
            //x = (y -= 2); //x=2, y=2
            //x = y++;      //x=2, y=3;
            //x = y--;      //x=3, y=2;
            // Zadanie 2.7
            //int x, y = 5;   //x=0,  y=5
            //x = ++y * 2;    //x=12, y=6
            //x = y++;        //x=6,  y=7
            //x = y--;        //x=7,  y=6
            //Console.WriteLine(++y); // wyświetli się 7
            // Zadanie 2.8
            //bool x;                     //x=false
            //int y = 1, z = 1;           //x=false, y=1, z=1
            //x = (y == 1 && z++ == 1);   //x=true,  y=1, z=2
            // odp (a) x=true, y=1, z=2
            // Zadanie 2.9
            //a)
            //int x = 1, y = 4, z = 2;
            //bool wynik = (x++ > 1 && y++ == 4 && z-- > 0);
            //Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z); // wynik=False, x=2, y=4, z=2
            //b)
            //int x = 1, y = 4, z = 2;
            //bool wynik = (x++ > 1 & y++ == 4 && z-- > 0);
            //Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z); // wynik=False, x=2, y=5, z=2
            //c)
            //int x = 1, y = 4, z = 2;
            //bool wynik = (x++ > 1 & y++ == 4 & z-- > 0);
            //Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z); //wynik=False, x=2, y=5, z=1
            //d)
            //int x = 1, y = 3, z = 4;
            //bool wynik = (x == 1 || y++ > 2 || ++z > 0);
            //Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z); // wynik=True, x=1, y=3, z=4
            // e)
            //int x = 1, y = 3, z = 4;
            //bool wynik = (x == 1 || y++ > 2 || ++z > 0);
            //Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z); // wynik=True, x=1, y=3, z=4
            // f)
            //int x = 1, y = 3, z = 4;
            //bool wynik = (x == 1 | y++ > 2 | ++z > 0);
            //Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z); // wynik=True, x=1, y=4, z=5
            // Zadanie 2.10
            //int powierzchnia = 100, osoby = 10;
            //double gestoscZaludnienia = (double)osoby / powierzchnia;
            //// należy wykonać rzutowanie na double, ponieważ domyślnie
            //// wynik dzielenia liczb calkowitych jest liczba calkowita
            //Console.WriteLine(gestoscZaludnienia);
        }
    }
}
