using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[ ] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "mavi";
            //colors[3] = "yeşil";
            ////Console.WriteLine(colors[0]);
            //Console.WriteLine(colors[3]);

            //int[] numbers = new int[3];
            //numbers[1] = 0;
            //Console.WriteLine(numbers[2]);

            //bool[] answers = new bool[3];
            //Console.WriteLine(answers[1]);

            //string[] animals = {};
            //int[] nums = new int[0];

            //nums = new int[3];
            #endregion



            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "kırmızı", "sarı", "mavi", "yeşil", "turuncu", "pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 153, 2532, 397, 4189, 537, 684, 7325, 68, 39 };
            //Array.Sort(numbers);

            //Array.Reverse(numbers);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //int numbersMax = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > numbersMax)
            //    {
            //        numbersMax = numbers[i];
            //    }
            //}
            //Console.WriteLine(numbersMax);



            //string[] persons = { "Ali", "Veli", "Ayşe", "Fatma", "Ahmet" };

            //Console.WriteLine(persons.Length);

            #endregion

            #region DiziMetodları

            //string[] customers = { "Ali", "Veli", "Ayşe", "Fatma", "Ahmet" };

            //int index = Array.IndexOf(customers, "Ayşe");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 89, 78, 96, 5 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + " Dizinin en küçük elemanı: " + numbers.Min() );
            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen {i+1}. şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine("Girmiş olduğunuz şehirler: ");

            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            int[] numbers = { 45, 89, 78, 96, 5 };

            //int sum = 0;
            //foreach (var item in numbers)
            //{
            //    sum += item;
            //}

            //Console.WriteLine("Dizideki sayıların toplamı: " + sum);


            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            #endregion
        }
    }
}
