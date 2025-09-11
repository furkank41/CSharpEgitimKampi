using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            // 1- Değişken Türü    
            // 2- Değişken Adı
            // 3- İn
            // 4- Liste, Koleksiyon, Dizi

            //List<int> numbers = new List<int>() { 1, 4, 6, 74, 744 };
            //Console.WriteLine(numbers[0]);

            //string word = "Merhaba";
            //foreach (char w in word)
            //{
            //    Console.WriteLine(w);
            //}

            #endregion

            #region Öğrenci Sınav Notları Uygulaması

            //Console.Write("Öğrenci Sayısı: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //int totalNote = 0; 

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{i+1}. öğrencinin notunu giriniz: ");
            //    int studentNote = int.Parse(Console.ReadLine());
            //    totalNote += studentNote;
            //}
            //int averageNote = totalNote / studentCount;
            //Console.WriteLine();
            //Console.WriteLine("Ortalama Not: " + averageNote);

            Console.Write("Öğrenci Sayısını Gir!: ");
            int studentCount = int.Parse(Console.ReadLine());
            double[] studentAverages = new double[studentCount];
            string[] studentNames = new string[studentCount];
            double totalNote = 0;
            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin adını giriniz: ");
                studentNames[i] = Console.ReadLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{i + 1}. öğrencinin {j + 1}. sınav notunu giriniz: ");
                    totalNote += double.Parse(Console.ReadLine());
                }
                studentAverages[i] = totalNote / 3;
                totalNote = 0;
                Console.WriteLine();
            }
           
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentAverages[i]} ");

                //öğrencilerin geçip kalma durumları

                if (studentAverages[i] > 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçmiştir.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kalmıştır.");

                }

            }

            Console.ReadKey();
            #endregion

        }
    }
}
