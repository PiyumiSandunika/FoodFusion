using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace DesktopApplication
{
    internal class CashierOrderFormProdData
    {
        public int ID { get; set; } //0
        public string ProductID { get; set; } //1
        public string ProductName { get; set; } //2
        public string Type { get; set; } //3
        public string Stock { get; set; } //4
        public string Price { get; set; } //5
        public string Status { get; set; } //6

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\restaurant.mdf;Integrated Security=True;Connect Timeout=30");


        public List<CashierOrderFormProdData> availableProductsData()    //menu table create
        {
            List<CashierOrderFormProdData> listData = new List<CashierOrderFormProdData>();

            if (connect.State == ConnectionState.Closed)

            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM products WHERE prod_status = @stats AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@stats", "Available");

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            CashierOrderFormProdData apd = new CashierOrderFormProdData();

                            apd.ID = (int)reader["id"];
                            apd.ProductID = reader["prod_id"].ToString();
                            apd.ProductName = reader["prod_name"].ToString();
                            apd.Type = reader["prod_type"].ToString();
                            apd.Stock = reader["prod_stock"].ToString();
                            apd.Price = reader["prod_price"].ToString();
                            apd.Status = reader["prod_status"].ToString();

                            listData.Add(apd);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed Connection: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;
        }
    }
}
