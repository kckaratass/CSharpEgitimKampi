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

            // Console.WriteLine("Merhaba Dünya");
            // Console.WriteLine("Selam);

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine("");
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine("");
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String Değişkenler (Variables)

            // String
            // Değişken_türü değişken_adi;

            //string name;
            //name = "Kadir Can";
            //Console.Write(name);   

            //String customerName;
            //String customerSurname;
            //String customerPhone;
            //String customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Karataş";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "customer@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("----------------------------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+ 90 400 300 80 70";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("----------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("----------------------------------------------------");
            #endregion

            #region INT Değişkenler

            //int
            // int number = 24;
            // Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("----- Hamburger Fiyatı: " + hamburgerPrice + "TL");
            Console.WriteLine("----- Kola Fiyatı: " + cokePrice + "TL");
            Console.WriteLine("----- Su Fiyatı: " + waterPrice + "TL");
            Console.WriteLine("----- Kızartma Fiyatı: " + friesPrice + "TL");
            Console.WriteLine("----- Pizza Fiyatı: " + pizzaPrice + "TL");
            Console.WriteLine("----- Limonata Fiyatı: " + lemonadePrice + "TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();

            int hamburgerCount = 3;
            int cokeCount = 3;
            int waterCount = 3;
            int friesCount = 1;
            int pizzaCount = 0;
            int lemonadeCount = 0;

            // Hesaplamalar
            int totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            int totalCokePrice = cokeCount * cokePrice;
            int totalWaterPrice = waterCount * waterPrice;
            int totalFriesPrice = friesCount * friesPrice;
            int totalPizzaPrice = pizzaCount * pizzaPrice;
            int totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL ");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + "TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + "TL");

            Console.WriteLine();

            int totalPrice = totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice + totalHamburgerPrice;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "TL");

            #endregion
            Console.Read();
        }
    }
}
