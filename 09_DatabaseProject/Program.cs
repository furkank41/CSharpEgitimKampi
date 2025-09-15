using System;
using System.Data;
using System.Data.SqlClient;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net

            Console.WriteLine("C# Veri Tabanlı Ürün");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasınız giriniz: ");
            string tableNumber = Console.ReadLine();    
            

            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;initial Catalog=EgitimKampiDb;integrated security= true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            connection.Close();
            foreach (DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }
          


            Console.Read();
        }
    }
}
