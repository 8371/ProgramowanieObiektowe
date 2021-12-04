using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_PO
{
    class koszyk
    {
        private List<produkt> lista_towarow;
        public koszyk()
        {
            this.lista_towarow = new List<produkt> { };
        }
        public void dodajProdukt(produkt prod)
        {
            this.lista_towarow.Add(prod);
            Console.WriteLine("Dodales {0} {1} zł do koszyka!", prod.nazwa, prod.cena);
        }
        public void wszystkieProdukty()
        {
            Console.WriteLine("Liczba wszystkich produktów: [{0}]", this.lista_towarow.Count);
            double suma = 0;
            foreach (produkt prod in this.lista_towarow)
                suma += prod.cena;
            Console.WriteLine("Suma wszystkich produktów wynosi: {0} zł", suma);
        }
    }
}
