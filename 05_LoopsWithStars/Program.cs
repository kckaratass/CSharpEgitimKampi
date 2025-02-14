using System;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            #region Alt Alta 10 Tane Yıldız Oluşturma

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("*");
            }

            Console.WriteLine(); // Boşluk bırak

            #endregion

            #region Yan Yana 10 Tane Yıldız Oluşturma

            for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine("\n"); // Satır atla

            #endregion

            #region 10x10 Yıldız Kare Oluşturma

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(); // Boşluk bırak

            #endregion

            #region Yıldızlarla Dik Üçgen Oluşturma

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine(); // Boşluk bırak

            #endregion

            #region Ters Dik Üçgen

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine(); // Boşluk bırak

            #endregion

            #region Dik ve Ters Üçgen Beraber Bulundurma

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine(); // Boşluk bırak

            #endregion

            #region Baklava Dilimi

            int n = 5; // Baklava diliminin yarı yüksekliği

            // Üst Kısım
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            // Alt Kısım
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            #endregion

            #region Piramit

            for (int i = 1; i <= n; i++)
            {
                // Boşluklar için
                for (int j = n - 1; j >= i; j--)
                {
                    Console.Write(" ");
                }
                // Yıldızlar için
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            #region Ters Piramit

            for (int i = n; i >= 1; i--)
            {
                // Boşluklar için
                for (int j = n; j >= i; j--)
                {
                    Console.Write(" ");
                }

                // Yıldızlar için
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            Console.ReadLine();
            */
        }
    }
}
