using System; fsafsafs
using System.CodeDom;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
14ed23aa7d4e635ad0e15dd3594307fb54c47b2a
namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            //() Metot Tanımlama

            //void Metot1()
            // int,char,string,bool,float,double,decimal Metot2()

          /void CustomerList()
           {
              Console.WriteLine("Fatma Yıldız");
            //}

            //CustomerList();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Ali Yıldız");
            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine("Toplam: " + result);
            //}
            //Sum(10, 20, 30);

            #endregion

            #region Geriye Değer Döndüren Methodlar

            //    string customerName()
            //    {
            //        return "Furkan Karagöz";
            //    }

            //    Console.WriteLine(customerName());

            //    string studentCard()
            //    {
            //        string name = "Burak";
            //        string surname = "Yılmaz";

            //       return name + " " + surname;
            //    }

            //    Console.WriteLine(studentCard());
            //}

            #endregion

            #region Geriye Değer Döndüren Parametreli Metotlar

            //string x, y, z;
            //string countryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + "\nBaşkent: " + capital + "\nBayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();
            //Console.Write("Başkent adını giriniz: ");
            //y = Console.ReadLine();
            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();
            //Console.WriteLine(countryCard(x, y, z));

            Console.WriteLine();           
            #endregion

            #region Simülasyon
            
            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1+exam2 + exam3)/3;
                if (result >= 50)
                {
                    return $"{student} isimli öğrenci sınavdan {result} ortalamayla geçti.";
                }
                else
                {
                    return $"{student} isimli öğrenci sınavdan {result} ortalamayla kaldı.";
                }

            }
            Console.WriteLine(ExamResult("Furkan",50,65,15));


            #endregion
        }

    }
}
