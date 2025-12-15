using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net 

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategory Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Sparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istedğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("------------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source = DESKTOP-NFEPLMA\\SQLEXPRESS ;Initial Catalog=EgitimCampiDB ;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("select * from TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable(); // verileri ramde tutmak için
            adapter.Fill(dataTable); // ramdaki verilerile(adapter) tabloyu doldurduk
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
