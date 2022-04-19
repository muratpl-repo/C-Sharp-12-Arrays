using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53DersDiziler
{
    class Program
    {

        class Insan // Once sinif olusturduk
        {
            public Insan(string isim, int yas) //Constructor methot olusturduk
            {
                this.Isim = isim;
                this.Yas = yas;
            }

            public string Isim { get; set; }  //Auto implemented Property olusturduk
            public int Yas { get; set; }      //Auto implemented Property olusturduk

        }
        static void Main(string[] args)
        {

            ///////////// ORNEK KULLANIM /////////////
            Insan i1 = new Insan("Murat", 26);
            Insan i2 = new Insan("Ulas",27);
            Insan[] insanlar = { i1, i2 };
            
            for (int i = 0; i < insanlar.Length; i++)
            {
                Console.WriteLine(insanlar[i].Isim + " " + insanlar[i].Yas);
            }
            //////////////////////////////////////////


            int[] sayilar = new int[4]; //1. Olusturma
            sayilar[0] = 5;
            sayilar[1] = 10;
            sayilar[2] = 15;
            sayilar[3] = 20;

            for(int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            int[] sayilar2 = new int[4] { 1, 2, 3, 4 }; //2. Olusturma

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar2[i]);
            }

            int[] sayilar3 = { 2, 4, 6, 8 }; //3. Olusturma
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar3[i]);
            }

            
            System.Convert.ToInt16

            


        }
    }
}
