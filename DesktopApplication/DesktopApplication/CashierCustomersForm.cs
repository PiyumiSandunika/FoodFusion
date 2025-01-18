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
    public partial class CashierCustomersForm : UserControl
    {
        public CashierCustomersForm()
        {
            InitializeComponent();

            displayCustomersData();
        }

        public void displayCustomersData()
        {
            CustomersData cData = new CustomersData();

            List<CustomersData> listData = cData.allCustomersData();


            datagridview1.DataSource = listData;
        }
    }
}
