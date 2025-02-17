using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            // Metot olabilmesi için () içerisinde parametre alması gerekmektedir
            // Metotlar, ikiye ayrılırlar. Geriye değer dönen metotlar ve geriye değer dönmeyen metotlar
            // Customer --> Listele,ekle,sil,güncelle

            // Geriye Değer Dönmeyen Metotlar (void)
            // Geriye Değer Döndürmeyen Metotlar, işlem sonucunda herhangi bir değer döndürmezler.
            //void CustomerList()
            //{
            //    Console.WriteLine("Kadir Can Karataş");
            //    Console.WriteLine("Ali Karataş");
            //    Console.WriteLine("Nevin Karataş");
            //    Console.WriteLine("Tuğçe Karataş");
            //}

            //void sum()
            //{
            //    int number1, number2, result;

            //    Console.Write("İlk sayıyı giriniz: ");
            //    number1 = int.Parse(Console.ReadLine());

            //    Console.Write("İkinci sayıyı giriniz: ");   
            //    number2 = int.Parse(Console.ReadLine());

            //    result = number1 + number2;

            //    Console.Write("Toplam: " + result);
            //}

            //CustomerList();
            //sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Kadir Can Karataş");

            //void customerCard(string customerName, string customerSurname)
            //{
            //    Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //}

            //customerCard("Kadir Can", "Karataş");
            //customerCard("Ali", "Karataş"); 
            //customerCard("Nevin", "Karataş");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine("Toplam: " + result);
            //}

            //sum(5, 10, 25);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string studentCard()
            //{
            //    string studentName = "Ali";
            //    string studentSurname = "Karataş";

            //    return studentName + " " + studentSurname;
            //}

            //Console.WriteLine(studentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string countryCard(string countryName, string countryCapital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + "\nBaşkent: " + countryCapital + "\nBayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;

            //Console.Write("Ülke Adı: ");
            //x = Console.ReadLine();

            //Console.Write("Başkent: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengi: ");
            //z = Console.ReadLine(); 

            //Console.WriteLine(countryCard(x, y, z));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));

            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti. Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci başarısız oldu. Ortalama: " + result;
            //    }
            //}

            // Main metodu içinde çağrılmalı
            //Console.WriteLine(ExamResult("Ali", 25, 40, 85));
            //Console.WriteLine(ExamResult("Nevin", 45, 85, 45));

            #endregion
        }
    }
}
