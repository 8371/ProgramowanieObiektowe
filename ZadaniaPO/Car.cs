
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_PO
{
    class Car
    {
        private int rok;
        private string marka;
        private string model;
        private int iloscDrzwi;
        private double pojemnoscSilnika;
        public double srednieSpalanie;
        public string set_model
        {
            set { model = value; }
            get { return model; }
        }
        public double set_srednieSpalanie
        {
            set { srednieSpalanie = value; }
            get { return srednieSpalanie; }
        }
        public int set_rok
        {
            set { rok = value; }
            get { return rok; }
        }
        public string set_marka
        {
            set { marka = value; }
            get { return marka; }
        }

        public Car(int rok=0, string marka="")
        {
            this.rok = rok;
            this.marka = marka;
        }
        public void wyswietl()
        {
            Console.WriteLine("Car marka = {0}, rok = {1}", this.marka, this.rok);
        }
        private double ObliczeSpalanie(double dlugoscTrasy)
        {
            return this.srednieSpalanie * dlugoscTrasy;
        }
        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            double spalanie = this.ObliczeSpalanie(dlugoscTrasy);
            Console.WriteLine("Spalanie wynosi: {0}", spalanie);
            return spalanie * cenaPaliwa;
        }
    }
}
