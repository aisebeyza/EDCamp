using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "abm";
            int yas = 23;

            Kurs kurs1= new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.egitmen = "engin";
            kurs1.izlenme_orani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.egitmen = "engin";
            kurs2.izlenme_orani = 58;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.egitmen = "engin";
            kurs3.izlenme_orani = 78;

           // Console.WriteLine(kurs1.KursAdi+": "+ kurs1.egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ": " + kurs.egitmen+ "\nİzlenme oranı: "+ kurs.izlenme_orani);
                
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string egitmen { get; set; }
        public int izlenme_orani { get; set; }
    }
}
