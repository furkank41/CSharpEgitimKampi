using System;


namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}
            //Console.Read();

            //string capital, country;
            //Console.Write("Lütfen başkanti giriniz:");
            //capital = Console.ReadLine();

            //Console.Write("Lütfen ülke ismini giriniz:");
            //country = Console.ReadLine();

            // if (capital == "Ankara" & country == "Türkiye")
            //{
            //    Console.WriteLine("Tebrikler bildiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış bildiniz");
            //}
            //Console.ReadLine();
            #endregion       
            #region Example
            //string result;
            //int exam1, exam2, exam3, average;
            //Console.Write("Lütfen 1. sınav notunu giriniz:");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. sınav notunu giriniz:");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3. sınav notunu giriniz:");
            //exam3 = int.Parse(Console.ReadLine());
            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması: " + average);
            //if (average < 50 & average > 0)
            //{
            //    result = "Kaldınız";
            //}
            //else if (average >= 50 & average < 70)
            //{
            //    result = "Orta";
            //}
            //else if (average >= 70 & average < 85)
            //{
            //    result = "İyi";
            //}
            //else if (average >= 85 & average <= 100)
            //{
            //    result = "Çokiyi";
            //}
            //else
            //{
            //    result = "Geçersiz not girdiniz";
            //}
            //Console.Write(result);

            #endregion
            #region Example2
            //Console.WriteLine("Furkan Restoran'a Hoşgeldinizzzz!!!!");
            //Console.WriteLine("Lütfen Yemek İstediğiniz Yemeğin Seçimini Yapınız: ");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- İçecekler");
            //Console.WriteLine("3-Tatlılar");
            //Console.WriteLine();
            //char secim = ' ';
            //secim =char.Parse(Console.ReadLine());
            //if (secim == '1')
            //{
            //    Console.WriteLine("Hangi Yemeği Yemek İstiyorsunuz");
            //    Console.WriteLine("Çorba");
            //    Console.WriteLine("Pizza");
            //    Console.WriteLine("Döner");
            //}
            //else if (secim == '2')
            //{
            //    Console.WriteLine("Hangi İçeceği İstiyorsunuz");
            //    Console.WriteLine("Kola");
            //    Console.WriteLine("Fanta");
            //    Console.WriteLine("Ayran");
            //}
            //else if (secim == '3')
            //{
            //    Console.WriteLine("Hangi Tatlıyı Yemek İstiyorsunuz");
            //    Console.WriteLine("Kadayıf");
            //    Console.WriteLine("Baklava");
            //    Console.WriteLine("Dondurma");
            //}            
            #endregion
            #region FinalExample
            //int monthNumber;
            //Console.Write("Lütfen ay numarasını giriniz: ");
            //monthNumber = int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Ocak ayındasınız");
            //        break;
            //    case 2:
            //        Console.WriteLine("Şubat ayındasınız");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart ayındasınız");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan ayındasınız");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayıs ayındasınız");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran ayındasınız");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz ayındasınız"); 
            //        break;
            //        case 8:
            //            Console.WriteLine("Ağustos ayındasınız");
            //            break;
            //        case 9:
            //            Console.WriteLine("Eylül ayındasınız");
            //            break;
            //        case 10:
            //            Console.WriteLine("Ekim ayındasınız");
            //            break;
            //        case 11:
            //            Console.WriteLine("Kasım ayındasınız");
            //            break;
            //        case 12:
            //            Console.WriteLine("Aralık ayındasınız");
            //            break;

            //    default:
            //        Console.WriteLine("Hatalı giriş yaptınız...");
            //        break;
            //}

            #endregion
            #region BuSeferGercektenSon

            int number1, number2, result;
            char symbol;

            Console.WriteLine("1.sayıyı gir!");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2.sayıyı gir!");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Yapmak istediğin işlemi gir: + - * /");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam: " + result);
                    break;

                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Fark: " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım: " + result);
                    break;

                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölüm: " + result);
                    break;
                default:
                    break;
            }

            #endregion
        }
    }
}
