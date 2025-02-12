﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password = Console.ReadLine();
            //if(password == "abcd")
            //{
            //    Console.WriteLine("Sifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if(capital == "ankara" & country == "türkiye") 
            //{
            //    Console.Write("Veriler doğrulandı.");
            //}
            //else
            //{
            //    Console.Write("hatalı bilgi.");
            //}

            //int number;
            //Console.Write("Lütfen bir sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if(number == 5)
            //{
            //    Console.WriteLine("Sayi doğrudur.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayi hatalı.");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata! ";

            //Console.Write("1. Sınav Notununuz: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sınav Notununuz: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("3. Sınav Notununuz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç Çok İyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen Şehir Girişi Yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Sehir mevcut.");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();

            //if(username != "admin") 
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoşgeldiniz.");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1.sayının 2.sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if(number % 2 == 0)
            //{
            //    Console.Write("Sayı Çifttir.");
            //}
            //else
            //{
            //    Console.Write("Sayı Tektir.");
            //}
            #endregion

            #region Char Değişkenler ile Karar Yapıları

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if(team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}

            //if(team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}

            #endregion

            #region Örnek Proje Uygulaması
            //Console.WriteLine("****** C# Eğitim Kampı Restoranı ******");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("1 - Ana Yemekler");
            //Console.WriteLine("2 - Çorbalar");
            //Console.WriteLine("3 - Pizzalar");
            //Console.WriteLine("4 - İçecekler");
            //Console.WriteLine("5 - Tatlılar");
            //Console.WriteLine("------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz için menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if(menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------- Ana Yemekler -------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Köri Soslu Tavuk");
            //    Console.WriteLine("2 - Kızartma Tabağı");
            //    Console.WriteLine("3 - Fasulye Pilav");
            //    Console.WriteLine("4 - Fırında Somon");
            //    Console.WriteLine("5 - Patlıcan Musakka");
            //    Console.WriteLine("------------- Ana Yemekler -------------");

            //    Console.WriteLine();

            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------- Çorbalar -------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Mercimek Çorbası");
            //    Console.WriteLine("2 - Ezogelin");
            //    Console.WriteLine("------------- Çorbalar -------------");

            //    Console.WriteLine();

            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------- Pizzalar -------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Akdeniz Pizza");
            //    Console.WriteLine("2 - Margarita");
            //    Console.WriteLine("3 - Tavuklu Pizza");
            //    Console.WriteLine("------------- Pizzalar -------------");

            //    Console.WriteLine();

            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------- İçecekler -------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Kola");
            //    Console.WriteLine("2 - Ayran");
            //    Console.WriteLine("2 - Su");
            //    Console.WriteLine("------------- İçecekler -------------");

            //    Console.WriteLine();

            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------- Tatlılar -------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Triliçe");
            //    Console.WriteLine("2 - Kazandibi");
            //    Console.WriteLine("3 - Sütlaç");
            //    Console.WriteLine("------------- Tatlılar -------------");

            //    Console.WriteLine();

            //}



            #endregion

            #region Switch - Case

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch(monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Ocak");
            //        break;
            //    case 2:
            //        Console.WriteLine("Şubat");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayıs");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ağustos");
            //        break;
            //    case 9:
            //        Console.WriteLine("Eylül");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ekim");
            //        break;
            //    case 11:
            //        Console.WriteLine("Kasım");
            //        break;
            //    case 12:
            //        Console.WriteLine("Aralık");
            //        break;
            //    default:
            //        Console.Write("Hatalı veri girişi.");
            //        break;
            //}

            #endregion

            #region Switch - Case - Hesap Makinesi -Uygulama

            int number1, number2, result;
            char symbol;

            Console.Write("Lütfen 1. sayıyı giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen 2. sayıyı giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen işlem sembolünü giriniz: ");
            symbol = char.Parse(Console.ReadLine());

            
            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplama İşlemi Sonucu: " + result);
                    break;

                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Çıkarma İşlemi Sonucu: " + result);
                    break;

                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpma İşlemi Sonucu: " + result);
                    break;

                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölme İşlemi Sonucu: " + result);
                    break;
            }
            
            #endregion

            Console.Read();
        }
    }
}
