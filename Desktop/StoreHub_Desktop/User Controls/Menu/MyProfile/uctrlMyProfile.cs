using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreHub_Desktop.User_Controls.Menu
{
    public partial class uctrlMyProfile : UserControl
    {

        public Action OnEdit;

        public Action OnPressBack;


        public uctrlMyProfile()
        {
            InitializeComponent();
        }

        private async void uctrlMyProfile_Load(object sender, EventArgs e)
        {
            uctrlUserDetailsCard1.SetData();
            uctrlUserDetailsRowsWithEdit2.OnSave += (a) =>
            {
                uctrlUserDetailsCard1.SetData();
                OnEdit?.Invoke();
            };

            await uctrlUserDetailsRowsWithEdit2.SetData();

        }

        private void lblBtnBack_Click(object sender, EventArgs e)
        {
            OnPressBack?.Invoke();
        }
    }
}
