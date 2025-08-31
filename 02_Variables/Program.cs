using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doubleDegiskenler
            //double applePrice = 15.99;
            //double orangePrice = 12.50;
            //double strawberryPrice = 20.75;
            //double potatoPrice = 15;
            //double tomatoPrice = 18.25;

            //double appleGram = 0.500;
            //double orangeGram = 0.750;
            //double strawberryGram = 1.25;
            //double potatoGram = 2;
            //double tomatoGram = 1.5;

            //double totalApplePrice = applePrice * appleGram;
            //double totalOrangePrice = orangePrice * orangeGram;
            //double totalStrawberryPrice = strawberryPrice * strawberryGram;
            //double totalPotatoPrice = potatoPrice * potatoGram;
            //double totalTomatoPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine("************ Toplam Fiyatlar ************");

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + totalApplePrice);
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + totalOrangePrice);
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + totalStrawberryPrice);
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + totalPotatoPrice);
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + totalTomatoPrice);

            //double shoppingTotalPrice = totalApplePrice + totalOrangePrice + totalStrawberryPrice + totalPotatoPrice + totalTomatoPrice;
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş toplam tutar: " + shoppingTotalPrice + " TL");

            //Console.Read();
            #endregion

            #region Klavyeden Veri Girişleri String Degişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ***** \n");

            //string passangerName, customerSurname, customerDistrict, customerCity, customerAge, customerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();

            //Console.WriteLine();

            //Console.Write("Yolcu Soyadı: ");
            //customerSurname = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("***************");
            //Console.WriteLine("Yolcu Adı Soyadı:  "  + passangerName + " " + customerSurname);


            //int customerAgeInt;
            //customerAgeInt = Int32.Parse( Console.ReadLine());

            #endregion
            #region Alışveriş Listesi

            //double computerPrice = 15000;
            //double phonePrice = 8000;

            //int computerCount, phoneCount;
            //Console.Write("Bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.Write("Telefon sayısını giriniz: ");
            //phoneCount = int.Parse(Console.ReadLine());

            //double totalComputerPrice = computerPrice * computerCount;
            //double totalPhonePrice = phonePrice * phoneCount;
            //double totalShoppingPrice = totalComputerPrice + totalPhonePrice;

            //Console.WriteLine("Alışveriş Toplam Tutarı: " + totalShoppingPrice + " TL");
            #endregion
            #region Klavyeden Ondalıklı Veri Girişleri

            //double exam1, exam2, exam3, averageNote;
            //Console.Write("1. Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("2. Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("3. Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());
            //averageNote = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sınav ortalamanız: " + averageNote);

            #endregion
            Console.Write("lütfen bir karakter giriniz.");
            char character = char.Parse(Console.ReadLine());
            Console.WriteLine("Girilen karakter: " + character);
        }
    }
}
