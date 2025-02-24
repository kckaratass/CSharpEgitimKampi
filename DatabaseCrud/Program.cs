using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kategori Ekleme İşlemi
            // Crud İşlemleri --> Create Read Update Delete

            //Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            //Console.WriteLine();

            //Console.WriteLine("------------------------------");
            //Console.Write("Eklemek İstediğniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            // SqlConnection connection = new SqlConnection("Data Source = THINKPAD\\SQLEXPRESS; Initial Catalog = EgitimKampiDb; Integrated Security = True;");
            // connection.Open();
            // SqlCommand command = new SqlCommand("INSERT INTO TblCategory (CategoryName) VALUES (@p1)", connection);
            // command.Parameters.AddWithValue("@p1", categoryName);
            // command.ExecuteNonQuery();
            // connection.Close();

            //Console.Write("Kategori Başarıyla Eklendi!");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            // SqlConnection connection = new SqlConnection("Data Source = THINKPAD\\SQLEXPRESS; Initial Catalog = EgitimKampiDb; Integrated Security = True;");
            // connection.Open();
            // SqlCommand command = new SqlCommand("INSERT INTO TblProduct (ProductName, ProductPrice, ProductStatus) VALUES (@productName, @productPrice, @productStatus)", connection);
            // command.Parameters.AddWithValue("@productName", productName);
            // command.Parameters.AddWithValue("@productPrice", productPrice);
            // command.Parameters.AddWithValue("@productStatus", true);
            // command.ExecuteNonQuery();
            // connection.Close();

            //Console.Write("Ürün Eklemesi Başarılı!");
            #endregion

            #region Ürün Listeleme İşlemi

            // SQL Server'a bağlanmak için bir bağlantı nesnesi oluşturuyoruz.
            // - Data Source: Veritabanı sunucusunun adı (Bilgisayar adı + SQL Server Instance adı)
            // - Initial Catalog: Kullanılacak veritabanının adı
            // - Integrated Security = True: Windows kimlik doğrulaması ile bağlanılacağını belirtir
            /*
            SqlConnection connection = new SqlConnection("Data Source = THINKPAD\\SQLEXPRESS; Initial Catalog = EgitimKampiDb; Integrated Security = True;");
            */

            // Veritabanı bağlantısını açıyoruz.
            /*
            connection.Open();
            */

            // SQL sorgusunu oluşturuyoruz. Burada "TblProduct" tablosundaki tüm verileri çekiyoruz.
            /*
            SqlCommand command = new SqlCommand("SELECT * FROM TblProduct", connection);
            */

            // SqlDataAdapter, SQL sorgularını çalıştırmak ve sonucu bir DataTable'a doldurmak için kullanılır.
            /*
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            */

            // Veritabanından çekilen verileri saklayacak DataTable nesnesini oluşturuyoruz.
            /*
            DataTable dataTable = new DataTable();
            */

            // Veritabanından çekilen tüm verileri DataTable'a doldurur.
            /*
            adapter.Fill(dataTable);
            */

            // DataTable içindeki her satırı döngü ile tek tek okuyoruz.
            /*
            foreach (DataRow row in dataTable.Rows)
            {
                // Her satırdaki tüm sütunları döngü ile okuyoruz.
                foreach (var item in row.ItemArray)
                {
                    // Sütun değerini ekrana yazdırıyoruz.
                    Console.Write(item.ToString() + " ");
                }

                // Satır bittiğinde yeni bir satıra geçiyoruz.
                Console.WriteLine();
            }
            */

            // Bağlantıyı kapatıyoruz, böylece kaynaklar boşa çıkmış olur.
            /*
            connection.Close();
            */

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silmek istediğiniz ürünün Id'sini giriniz: "); 
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = THINKPAD\\SQLEXPRESS; Initial Catalog = EgitimKampiDb; Integrated Security = True;");

            //connection.Open();

            //SqlCommand command = new SqlCommand("DELETE FROM TblProduct WHERE ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);

            //connection.Close();

            //Console.Write("Ürün başarıyla silindi!");

            #endregion

            #region Ürün Güncelleme İşlemi

            


            connection.Open();

            Console.Write("Güncellemek istediğiniz ürünün Id'sini giriniz: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürünün Adı: ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek Ürünün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source = THINKPAD\\SQLEXPRESS; Initial Catalog = EgitimKampiDb; Integrated Security = True;");
            SqlCommand command = new SqlCommand("UPDATE TblProduct SET ProductName = @productName, ProductPrice = @productPrice WHERE ProductId = @productId", connection);
            connection.Close();

            #endregion


            // Console.Read() bu noktada tek bir kez çağrılmalı, kod sonunda yer alması gerekir
            Console.Read();
        }
    }
}
