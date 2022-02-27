﻿using System;

namespace MetotTanimlama
{
    class Program
    {
        static void Main(string[] args)
        {
            // erişim_belirteci geri_dönüşümtipi metod_adı(parametresi/arguman)

            //{
                //komutlar
            //}

            int a = 2;
            int b = 3;

            System.Console.WriteLine(a+b);

            int sonuc = Topla(a,b);
           

            System.Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));
            
            int sonuc2 = ornek.ArttirveTopla(ref a, ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
        }


        static int Topla(int deger1, int deger2)
        {
            return (deger1+deger2);
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            System.Console.WriteLine(veri);
        }

        public int ArttirveTopla(ref int deger1, ref int deger2)
        {
            deger1 +=1;
            deger2 +=1;
            return deger1+deger2;
        }
    }
}
