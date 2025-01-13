using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace DesktopApplication
{
    public partial class CashierOrderForm : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\restaurant.mdf;Integrated Security=True;Connect Timeout=30");
        public CashierOrderForm()
        {
            InitializeComponent();

            displayAvailableProds();
        }

        public void displayAvailableProds()  //display available data in menu
        {
            CashierOrderFormProdData allProds = new CashierOrderFormProdData();

            List<CashierOrderFormProdData> listData = allProds.availableProductsData();

            cashierOrderForm_menuTable.DataSource = listData;
        }

        private void cashierOrderForm_addBtn_Click(object sender, EventArgs e)
        {

        }

        private void cashierOrderForm_type_SelectedIndexChanged(object sender, EventArgs e) //type selected
        {
            cashierOrderForm_productID.SelectedIndex = -1;
            cashierOrderForm_productID.Items.Clear();
            cashierOrderForm_productName.Text = "";
            cashierOrderForm_price.Text = "";

            string selectedValue = cashierOrderForm_type.SelectedItem as string;

  

             if (selectedValue != null)
             {
                         
                   try
                        
                   {
                    using(SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\restaurant.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        connect.Open();

                        string selectData = $"SELECT * FROM products WHERE prod_type = '{selectedValue}' AND prod_status = @status AND date_delete IS NULL";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string value = reader["prod_id"].ToString();

                                    cashierOrderForm_productID.Items.Add(value);
                                }
                            }
                        }
                    }

                            
                   }
                   catch (Exception ex)
                   {
                         MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }
             }
                
        }

        private void cashierOrderForm_productID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cashierOrderForm_productID.SelectedItem as string;

            if (selectedValue != null)
            {
                if(connect.State == ConnectionState.Closed)
                {
                    using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\restaurant.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        connect.Open();

                        string selectData = $"SELECT * FROM products WHERE prod_id = '{selectedValue}' AND prod_status = @status AND date_delete IS NULL";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string prodName = reader["prod_name"].ToString();
                                    string prodPrice = reader["prod_price"].ToString();

                                    cashierOrderForm_productName.Text = prodName;
                                    cashierOrderForm_price.Text = prodPrice;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
