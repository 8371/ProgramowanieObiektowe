using System;

namespace Zadania_PO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nZadanie 4");
            Car car1 = new Car();
            car1.set_rok = 1990;
            car1.set_marka = "Volvo";
            car1.wyswietl();

            //Console.WriteLine("\nZadanie 5");
            //Car car2 = new Car(2000, "Audi");
            //car2.wyswietl();

            //Console.WriteLine("\nZadanie 6");
            //car1 = car2;
            //car1.wyswietl();
            //car2.wyswietl();
            int rok_tmp;
            do
            {
                Console.WriteLine("Podaj rok produkcji, warunek większy od 1769, mniejszy od 2017");
                rok_tmp = Convert.ToInt32(Console.ReadLine());
            } while (!((rok_tmp > 1769) && (rok_tmp < 2017)));
            Console.WriteLine("Wprowadziles poprawne dane! rok={0}", rok_tmp);
            car1.set_rok = rok_tmp;
            car1.set_srednieSpalanie = 6.2;
            car1.set_model = "CV001";

            Console.WriteLine("Obliczam koszt przejazdu, podaj dlugosc trasy w km");
            double dlugosc = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj cene paliwa: ");
            double cena = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Koszt przejazdu wynosi: {0}", car1.ObliczKosztPrzejazdu(dlugosc, cena));
        }
    }
}
