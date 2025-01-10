using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApplication
{
    public partial class AdminAddUsers : UserControl
    {
        public AdminAddUsers()
        {
            InitializeComponent();

            displayAddUsersData();
        }
        public void displayAddUsersData()
        {
            AdminAddUsersData usersData = new AdminAddUsersData();
            List<AdminAddUsersData> listData = usersData.usersListData();

            dataGridView1.DataSource = listData;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
