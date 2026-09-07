using Shop_Desktop_Business;
using Shop_Desktop_Business.Other;
using StoreHub_Desktop.Classes;
using StoreHub_Desktop.Forms;
using StoreHub_DTOs.Login;
using System.Net.Http.Headers;
namespace StoreHub_Desktop
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            clsDefultes.Client.BaseAddress = new Uri("https://localhost:7172/api/");

            LoadRemember();

        }

        void LoadRemember()
        {
            (string email, string pass) = clsUtilty.LoadEmailPasswordFromCMW();

            if (!string.IsNullOrEmpty( email) &&!string.IsNullOrEmpty(pass))
            {
                txbEmail.Text = email;
                txbPassword.Text = pass;

                chkRememberMe.Checked = true;
            }
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            await LoginAsync();
            btnLogin.Enabled = true;

        }

        async Task LoginAsync()
        {
            if(!string.IsNullOrWhiteSpace(txbPassword.Text) && !string.IsNullOrWhiteSpace(txbEmail.Text))
            {
                try
                {

                    DTO_LoginRequest request = new DTO_LoginRequest();
                    request.Email =txbEmail.Text;
                    request.Password = txbPassword.Text;

                    var response = await clsPerson.Login(request);
                    
                    if(response != null)
                    {

                        CheckRemeberMe(request.Email, request.Password);

                        clsDefultes.LogendUser = response;

                        clsDefultes.Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", clsDefultes.LogendUser.AccessToken);


                        

                        OpenMainForm();
                    }


                }
                catch(Exception ex)
                {
                    clsUtilty.PrintWarn(ex.Message);
                }
            }
            else
            {
                clsUtilty.PrintWarn("PLease enter email/password");
            }
        }



        void OpenMainForm()
        {
            frmMainApp frm = new frmMainApp(this);
            Hide();
            frm.Show();
        }

        void CheckRemeberMe(string email, string password)
        {
            if (chkRememberMe.Checked)
                clsUtilty.SaveEmailPasswordInCMW(email, password);
            else
                clsUtilty.DeleteEmailPasswordFromCMW();
        }
    }
}
