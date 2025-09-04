using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForDongusu
            //Console.WriteLine("Lütfen ekrana yazılmasını istediğiniz adedi girin: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 0; i < finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasınn  " + i);
            //}

            //Console.Read();
            #endregion
            #region For Döngüsü ile Karar Yapıları

            //int totalValue = 0;
            //Console.Write("kaça kadar toplasın: ");
            //int kacakadartoplasın = int.Parse(Console.ReadLine());

            //for (int i = 0; i < kacakadartoplasın; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);

            //        totalValue += i;
            //    }

            //}

            //Console.WriteLine(totalValue);

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". saat sonunda bakteri sayısı: " + bacterium);
            //}
            //Console.WriteLine("24 saat sonrasında toplam bakteri sayısı: " + bacterium);
            #endregion
            #region While Döngüsü

            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum = sum + i;
            //    i++;

            //}
            //Console.WriteLine(sum);

            //int[] array = new int[] { };
            //foreach (var item in array)
            //{

            //}
            #endregion
            #region OrnekSınavSorusu
            // klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız
            Console.Write("3 basamaklı Sayıyı girin: ");
            int number = int.Parse(Console.ReadLine());
            int firstb = (number / 100);
            int secondb = ((number % 100) / 10);
            int thirdb = (number % 10);
            Console.WriteLine("basamakları toplamı: " + (firstb + secondb + thirdb));
            #endregion
        }
    }
}
