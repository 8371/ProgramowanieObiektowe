using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe5_6
{
    class BMI
    {
        private double waga;
        double wzrost;
        private double bmi;
        public double set_waga
        {
            get { return waga; }
            set { waga = value; }
        }
        public double set_wzrost
        {
            get { return wzrost; }
            set { wzrost = value; }
        }

        public void obliczBMI()
        {
            bmi = waga / (wzrost / 100 * wzrost / 100);
        }
        public void wskBMI()
        {
            if (bmi < 16)
                Console.WriteLine("wygłodzenie, BMI={0}", bmi);
            else if (bmi >= 16 && bmi <= 16.99)
                Console.WriteLine("wychudzenie, BMI={0}", bmi);
            else if (bmi >= 17 && bmi <= 18.49)
                Console.WriteLine("Niedowaga, BMI={0}", bmi);
            else if (bmi >= 18.5 && bmi <= 24.99)
                Console.WriteLine("Pożądana masa ciała, BMI={0}", bmi);
            else if (bmi >= 25 && bmi <= 29.99)
                Console.WriteLine("Nadwaga, BMI={0}", bmi);
            else if (bmi >= 30 && bmi <= 34.99)
                Console.WriteLine("Otylosc I stopnia, BMI={0}", bmi);
            else if (bmi >= 35 && bmi <= 39.99)
                Console.WriteLine("Otylosc II stopnia (duża), BMI={0}", bmi);
            else
                Console.WriteLine("Otylosc III stopnia (chorobliwa), BMI={0}", bmi);
        }
    }
}
