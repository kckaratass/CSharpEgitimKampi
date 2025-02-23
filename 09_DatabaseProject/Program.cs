using System;
using System.Data;
using System.Data.SqlClient;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****\n");

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            string tableNumber = Console.ReadLine();
            Console.WriteLine("---------------------------------------------");

            string connectionString = "Data Source=THINKPAD\\SQLEXPRESS; Initial Catalog=EgitimKampiDb; Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM TblCategory", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        Console.WriteLine("Kategori Listesi:\n");
                        foreach (DataColumn column in dataTable.Columns)
                        {
                            Console.Write(column.ColumnName + "\t");
                        }
                        Console.WriteLine("\n------------------------------------------------");

                        foreach (DataRow row in dataTable.Rows)
                        {
                            foreach (var item in row.ItemArray)
                            {
                                Console.Write(item + "\t");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }

            Console.Read();
        }
    }
}
