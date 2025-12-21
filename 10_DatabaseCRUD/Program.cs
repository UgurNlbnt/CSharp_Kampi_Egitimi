using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud -> create, read, update, delete
            #region Kategori ekleme işlemi
            //Console.WriteLine("***** Menü Siparis İşlem Paneli *****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------");

            //Console.Write("Eklemek istediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-NFEPLMA\\SQLEXPRESS ;Initial Catalog=EgitimCampiDB ;Integrated Security=True");
            //connection.Open(); 
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori Ekleme İşlemi Tamamlandı.");
            #endregion

            #region Ürün ekleme İşlemi
            //string productName;
            //decimal proutPrice;
            //bool proutStatus;

            //Console.Write(" ürün Adı: ");
            //productName = Console.ReadLine();

            //Console.Write("ürün Fiyatı: ");
            //proutPrice = Convert.ToDecimal(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-NFEPLMA\\SQLEXPRESS ;Initial Catalog=EgitimCampiDB ;Integrated Security=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProcuct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", proutPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("Ürün Ekleme İşlemi Tamamlandı.");
            #endregion

            #region Ürün Listeleme İşlemi
            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-NFEPLMA\\SQLEXPRESS ;Initial Catalog=EgitimCampiDB ;Integrated Security=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("select * from TblProcuct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.WriteLine(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silmek istediğiniz ürünün ID'sini giriniz: ");
            //int productId = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-NFEPLMA\\SQLEXPRESS ;Initial Catalog=EgitimCampiDB ;Integrated Security=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("delete from TblProcuct where ProductID=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("Ürün Silme İşlemi Tamamlandı.");
            //#endregion

            //#region Ürün Güncelleme İşlemi
            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-NFEPLMA\\SQLEXPRESS ;Initial Catalog=EgitimCampiDB ;Integrated Security=True");
            //connection.Open();



            #endregion

            #region Ürün Güncelleme İşlemi
            Console.Write("Güncellemek istediğiniz ürünün ID'sini giriniz: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Yeni ürün Adı: ");
            string productName = Console.ReadLine();

            Console.Write("Yeni ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source = DESKTOP-NFEPLMA\\SQLEXPRESS ;Initial Catalog=EgitimCampiDB ;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("update TblProcuct set ProductName=@productName, ProductPrice=@productPrice where ProductID=@productId", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();

            connection.Close();
            Console.WriteLine("Ürün Güncelleme İşlemi Tamamlandı.");

            #endregion

            Console.Read();
        }
    }
}
