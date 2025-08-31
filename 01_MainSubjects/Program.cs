using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region YazdırmaKomutları

            // Console.Write("Merhaba Dünya\n");
            // Console.WriteLine("Selam");

            //Console.WriteLine("***** Yemek Kategoriler *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategoriler *****");

            #endregion
            #region Degiskenler

            //string
            //Değişken_türü değişken_adı

            //string name;
            //name = "Furkan";
            //Console.Write(name);

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            customerName = "Ali";
            customerSurname = "Veli";
            customerPhone = "0555 555 55 55";
            customerEmail = "deneme@gmail.com";
            district = "Kadıköy";
            city = "İstanbul";

            Console.WriteLine("***** Rezervasyon Kartı ****");
            Console.WriteLine();
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            #endregion


            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int fricePrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Kola: " + cokePrice + " TL");
            Console.WriteLine("-----Su: " + waterPrice + " TL");
            Console.WriteLine("-----Kızartma: " + fricePrice + " TL");
            Console.WriteLine("-----Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("-----Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();

            int hamburgeCount, cokeCount, waterCount, friceCount, pizzaCount, lemonadeCount;
            int totalHamburgerPrice, totalCokePrice, totalWaterPrice, totalFricePrice, totalPizzaPrice, totalLemonadePrice;

            hamburgeCount = 2;
            cokeCount = 2;
            waterCount = 1;
            friceCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerPrice * hamburgeCount;
            totalCokePrice = cokePrice * cokeCount;
            totalWaterPrice = waterPrice * waterCount;
            totalFricePrice = fricePrice * friceCount;
            totalPizzaPrice = pizzaPrice * pizzaCount;
            totalLemonadePrice = lemonadePrice * lemonadeCount;

            Console.WriteLine("---------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFricePrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");

            Console.WriteLine();


            int totalPrice = totalLemonadePrice + totalPizzaPrice + totalFricePrice + totalWaterPrice + totalCokePrice + totalHamburgerPrice;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");
        }
    }
}
