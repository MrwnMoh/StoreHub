using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreHub_Desktop.Forms
{
    public partial class frmMainApp : Form
    {
        public frmMainApp()
        {
            InitializeComponent();
        }


        async Task LoadData()
        {
            await homeProducts1.LoadHomeProducts();
        }

        private async void frmMainApp_Load(object sender, EventArgs e)
        {
            await LoadData();
        }
    }
}
