using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YasHesapRapor
{
    class Program
    {
        public static int DogumTarihi()
        {
            int dogumtarihi;
            Console.WriteLine("Lütfen Doğum Tarihinizi Giriniz ");
            dogumtarihi = Convert.ToInt32(Console.ReadLine());
            return dogumtarihi;
        }
        public static string KullanıcıIsim()
        {
            string isim;
            Console.WriteLine("Lütfen adınızı giriniz ");
            isim = Console.ReadLine();
            return isim;

        }
        static void Main(string[] args)
        {  //Kullanıcıdan ad ve doğum tarihi bilgisini alıp yaşını hesaplayıp gösterelim. bunu metot kullanarak yapalım. ("Doğum tarihi bugünün tarihinden büyük olmamalıdır " şeklinde bir kontrol güzel olur.)
            //Console , windows ya da her ikisinde de yapabilrsiniz.

            //İsteğe bağlı olarak;
            //her 10 kişinin yaşını hesapladıktan sonra ekrana aşağıdaki raporu yazdıralım. 
            //Son 10 kullanıcının yaş ortalaması,
            //Son on kullanıcıdan gelen bilgiye göre en büyük yaş,
            //Son on kullanıcıdan yaşı 35 üstü olan kaç kişi olduğunu.
            int i = 1, gercekYas = 0, temp = 0, say = 0,geciciyas=0;
            double ortalama;
            
            while (i <= 10)
            {
            giris:
                int tarih = DogumTarihi();
                string isim = KullanıcıIsim();
                DateTime yil;
                yil = DateTime.Now;

                if (tarih >= yil.Date.Year)
                {
                    Console.WriteLine("Girilen Tarih Bugunden Büyük Olamaz");
                    goto giris;
                }
                else
                {
                    gercekYas = yil.Date.Year - tarih;
                    
                }
                if (gercekYas>geciciyas)
                {
                    geciciyas = gercekYas;
                }

                if (gercekYas > 35)
                {
                    say += 1;
                }
                Console.WriteLine(i + " . kisinin yasi : " + gercekYas + " adı : " + isim);
                Console.WriteLine();

                temp = temp + gercekYas;

                i++;
            }
            ortalama = temp / 10;
            Console.WriteLine("10 kisinin yasları toplamı : " + temp);
            Console.WriteLine("10 kisinin yasları ortalaması : " + ortalama);
            Console.WriteLine("Yası 35 ten buyuk kisi sayısı : " + say);
            Console.WriteLine("En Büyük Yaş : " +geciciyas);

            Console.ReadKey();

        }



    }
}
