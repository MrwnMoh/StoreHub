using StoreHub_DTOs.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreHub_Desktop.Forms.Admin
{
    public partial class frmAddEditUser : Form
    {

        public Action<DTO_PersonSummary> OnSaved;

        public frmAddEditUser(int? id)
        {
            InitializeComponent();

            _Id = id;

            if (!_Id.HasValue)
            {
                uctrlUserDetailsRowsWithEdit1.SetForAddUser = true;
            }
            uctrlUserDetailsRowsWithEdit1.OnSave += (personSummary) => OnSavedEvent(personSummary);

        }

        void OnSavedEvent(DTO_PersonSummary personSummary)
        {
            OnSaved?.Invoke(personSummary);
            Close ();
        }


        int? _Id;

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
           
        }

        public async Task LoadData(DTO_PersonSummary personSummary)
        {
            await uctrlUserDetailsRowsWithEdit1.SetData(personSummary);
        }

    }
}
