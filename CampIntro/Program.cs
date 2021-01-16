using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 3000000;
            double faizOrani = 1.45;
            bool girisyapildimi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış ikonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("artış ikonu");
            }
            else
            {
                Console.WriteLine("değişiklik yok");
            }

            if (girisyapildimi == true)
            {
                Console.WriteLine("Kullanıcı ayarlar butonu");

            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
