using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü

            // Foreach döngüsü, koleksiyonlar üzerinde dolaşmak için kullanılır.
            // Foreach döngüsü, koleksiyonun her bir elemanı üzerinde dolaşır
            // ve her bir elemanı belirtilen değişkene atar.

            // Foreach(1;2;3;4)
            // 1: Değişken türü
            // 2: Değişken adı
            // 3: In
            // 4: Liste, Koleksiyon Dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };
            //foreach(string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //Console.WriteLine("Çift Sayılar:");
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //Console.WriteLine("\nTek Sayılar:");
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 1)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;

            //foreach(int i in numbers)
            //{
            //    total += i;
            //}

            //Console.WriteLine("Toplam: " + total);

            //List<int> numbers = new List<int>() {
            //    1,2,3,4,5,8
            //};

            //foreach(int number in numbers )
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba Dünya";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}



            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Sınav Sistemi Uygulaması *****");
            Console.WriteLine("\n\n");

            // Sınıftaki Öğrenci Sayısını Kullanıcıdan Alalım
            Console.WriteLine("------------------------------");

            int studentCount;
            while (true)
            {
                Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
                if (int.TryParse(Console.ReadLine(), out studentCount) && studentCount > 0)
                    break;
                else
                    Console.WriteLine("Geçerli bir öğrenci sayısı giriniz!");
            }

            Console.WriteLine("------------------------------");

            // Öğrenci Adı ve Notlarını Tutacak Dizileri Oluşturma
            string[] studentName = new string[studentCount];
            double[] studentScore = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin Adı: ");
                studentName[i] = Console.ReadLine();

                double totalScore = 0; // Öğrencinin Notlarının Toplamını Tutacak Değişken

                // Her Bir Öğrencinin 3 Adet Notunu Kullanıcıdan Alalım
                for (int j = 0; j < 3; j++)
                {
                    double score;
                    while (true)
                    {
                        Console.Write($"{studentName[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                        if (double.TryParse(Console.ReadLine(), out score))
                            break;
                        else
                            Console.WriteLine("Geçerli bir sayı giriniz!");
                    }
                    totalScore += score;
                }
                Console.WriteLine();

                studentScore[i] = totalScore / 3; // Öğrencinin Notlarının Ortalamasını Alıp Diziye Ata
            }

            // Öğrencilerin Ortalamalarını Yazdırma ve Geçme Durumlarını Belirleme
            Console.WriteLine("\n***** Sınav Sonuçları *****");

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine($"{studentName[i]} adlı öğrencinin not ortalaması: {studentScore[i]:F2}");

                // Öğrencinin Geçme Durumu
                if (studentScore[i] >= 50)
                {
                    Console.WriteLine($"{studentName[i]} adlı öğrenci dersi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentName[i]} adlı öğrenci dersi geçemedi.");
                }

                Console.WriteLine("----------------------");
            }




            #endregion

            Console.Read();

        }
    }
}
