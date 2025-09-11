using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dik Üçgen

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("*" + i);
            //}

            /* 
            *
            **
            ***
            ****
            ******
             
             */
            //int i, y=0;
            //string star = "*";
            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(star);
            //    star += "*";

            //}

            #endregion
            #region Ters Dik Üçgen

            //for (int i = 0; i < 15; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("---------------");

            //for (int i = 15; i >= 1; i--)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava Dilimi

            Console.WriteLine("Satır sayısını giriniz: ");

            int satir = int.Parse(Console.ReadLine());

            for (int i = 0; i < satir; i++)
            {
                for (int k = satir; k-1 > i; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }

            for (int i = satir; i >=1; i--)
            {
                for (int k = satir; k  >= i; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            #endregion

            Console.Read();

        }
    }
}
