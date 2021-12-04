using System;

namespace Zadania_PO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 13");
            Osoba dyrektor = new Osoba();
            dyrektor.imie = "Jan";
            dyrektor.nazwisko = "Kowalski";
            dyrektor.rokUrodzenia = 1970;
            dyrektor.plec = Plec.M;
            Console.WriteLine("Imie: {0}", dyrektor.imie);
            Console.WriteLine("Nazwisko: {0}", dyrektor.nazwisko);
            Console.WriteLine("Wiek: {0}", dyrektor.obliczWiek());
            
            // Zadanie 14
            // Zmieni się zakres dostępu do tych pól
            // np. tylko metody wewnętrzne będą w stanie modyfikować
            // zawartość danej zmiennej.
            Console.WriteLine("Zadanie 15");
            dyrektor.przedrostek();

            Console.WriteLine("Zadanie 17");
            Osoba pacjent = new Osoba();
            pacjent.imie = "John";
            pacjent.nazwisko = "Lord";
            pacjent.waga = 78.2;
            pacjent.wzrost = 181;
            pacjent.wskBMI();

            Console.WriteLine("Zadanie 18");
            produkt prod1 = new produkt("Jabłko", 2.21);
            produkt prod2 = new produkt("Kurczak 1kg", 13.99);
            produkt prod3 = new produkt("Plyn do naczyn", 21.19);

            koszyk kosz = new koszyk();
            kosz.dodajProdukt(prod1);
            kosz.dodajProdukt(prod2);
            kosz.dodajProdukt(prod3);
            kosz.wszystkieProdukty();

            Console.WriteLine("Zadanie 19");
            Zespolone x1 = new Zespolone(1, 8);
            Zespolone x2 = new Zespolone(2, 3);
            Console.WriteLine("Liczba zesplona x1 = {0}", x1);
            Console.WriteLine("Liczba zesplona x2 = {0}", x2);
            Console.WriteLine("Dodawanie liczb zespolonych x1 + x2 = {0}", x1 + x2);
            Console.WriteLine("Odejmowanie liczb zespolonych x1 - x2 = {0}", x1 - x2);
            Console.WriteLine("Mnożenie liczb zespolonych x1 * x2 = {0}", x1 * x2);
            Console.WriteLine("Dzielenie liczb zespolonych x1 / x2 = {0}", x1 / x2);
        }

    }
}
