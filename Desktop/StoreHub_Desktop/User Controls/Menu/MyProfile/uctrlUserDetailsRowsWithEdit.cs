using Shop_Desktop_Business;
using Shop_Desktop_Business.Countries;
using Shop_Desktop_Business.Other;
using StoreHub_Desktop.Classes;
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
using System.Net.Mail;
using Shop_Desktop_Business.Admin;

namespace StoreHub_Desktop.User_Controls.Menu.MyProfile
{
    public partial class uctrlUserDetailsRowsWithEdit : UserControl
    {


        public bool SetForAddUser { get { return _SetForAddUser; } set { _SetForAddUser = value; ChangeMode(); } }

        bool _SetForAddUser = false;

        public Action<DTO_PersonSummary> OnSave;

        string email;
        string phone;

        int _personId;

        DTO_PersonSummary? _person;

        public uctrlUserDetailsRowsWithEdit()
        {
            InitializeComponent();
        }

        bool _inSaveMode = false;
        public async Task SetData(DTO_PersonSummary person = null)
        {
            await LoadCountries();

            if(person != null)
            {
                _person = person;
                email = person.Email;
                phone = person.Phone;
                phone = person.Phone;
                _personId = person.PersonId;
            }


            if (!_SetForAddUser && person == null)
            {
                email = clsDefultes.LogendUser.person.Email;
                phone = clsDefultes.LogendUser.person.Phone;
                _personId = clsDefultes.LogendUser.person.PersonId;
            }

            LoadTxbs();


        }



        void ChangeMode()
        {
            if (_SetForAddUser)
            {
                btnEdit.Text = "Saue";
                ChangeModeToEdit(true);
                lblbtnBack.Visible = false;
                lblbtnBack.Enabled = false;
            }
            else
            {
                btnEdit.Text = "Edit Profile";
                ChangeModeToEdit(false);
            }
        }

        async Task LoadCountries()
        {
            var countries = await clsCountries.LoadCountriesNames();
            foreach (var country in countries)
            {
                cmbCountries.Items.Add(country);
            }

            cmbCountries.SelectedIndex = 51;
        }

        void LoadTxbs()
        {
            if(_person == null)
            {
                if (_SetForAddUser)
                    return;
                tbxFirstName.Text = clsDefultes.LogendUser.person.FirstName;
                tbxSecondName.Text = clsDefultes.LogendUser.person.LastName;
                tbxEmail.Text = email;
                tbxAddress.Text = clsDefultes.LogendUser.person.Address;
                tbxPhone.Text = phone;
                cmbCountries.Text = clsDefultes.LogendUser.person.CountryName;
                dtpBirthdate.Value = clsDefultes.LogendUser.person.BirthDate.ToDateTime(TimeOnly.MinValue);
                clsUtilty.LoadUserImage(ref picUserPic, clsDefultes.LogendUser.person.ImagePath, clsDefultes.LogendUser.person.IsMale);
                if (!string.IsNullOrEmpty(clsDefultes.LogendUser.person.ImagePath))
                    llblRemoveImage.Visible = true;
                else
                    llblRemoveImage.Visible = false;
            }
            else
            {
                tbxFirstName.Text = _person.FirstName;
                tbxSecondName.Text = _person.LastName;
                tbxEmail.Text = _person.Email;
                tbxAddress.Text = _person.Address;
                tbxPhone.Text = _person.Phone;
                cmbCountries.SelectedIndex = _person.CountryId - 1;
                dtpBirthdate.Value = _person.BirthDate.ToDateTime(TimeOnly.MinValue);
                clsUtilty.LoadUserImage(ref picUserPic, _person.UserImagePath, _person.IsMale);
                if (!string.IsNullOrEmpty(_person.UserImagePath))
                    llblRemoveImage.Visible = true;
                else
                    llblRemoveImage.Visible = false;
            }
          
        }

        void ChangeModeToEdit(bool isTrue)
        {

            _inSaveMode = isTrue;

            tbxFirstName.Enabled = isTrue;
            tbxSecondName.Enabled = isTrue;
            tbxAddress.Enabled = isTrue;
            tbxPhone.Enabled = isTrue;
            tbxEmail.Enabled = isTrue;
            cmbCountries.Enabled = isTrue;
            dtpBirthdate.Enabled = isTrue;
            chkIsMale.Enabled = isTrue;
            llblRemoveImage.Enabled = isTrue;

            lblbtnBack.Visible = isTrue;
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {

            if (_SetForAddUser)
            {
                btnEdit.Enabled = false;
                await SaveNewUser();
                btnEdit.Enabled = true;
                return;
            }

            if (_inSaveMode)
            {
                btnEdit.Enabled = false;

                if(_person != null)
                await SaveEdits(_person.UserImagePath);
                else
                    await SaveEdits(clsDefultes.LogendUser.person.ImagePath);

                btnEdit.Enabled = true;
            }
            else
            {
                ChangeModeToEdit(true);
                btnEdit.Text = "Saue Edit";
            }


        }

        private void lblbtnBack_Click(object sender, EventArgs e)
        {
            ChangeModeToEdit(false);

            btnEdit.Text = "Edit Profile";

            LoadTxbs();
        }


        async Task SaveEdits(string? oldImagePath)
        {
            if (await CheckCondetions())
            {
                DTO_PersonEdit edit = new DTO_PersonEdit();
                edit.FirstName = tbxFirstName.Text;
                edit.LastName = tbxSecondName.Text;
                edit.Address = tbxAddress.Text;
                edit.PersonID = _personId;
                edit.Email = tbxEmail.Text;
                edit.PhoneNumber = tbxPhone.Text;
                edit.BirthDate = DateOnly.FromDateTime(dtpBirthdate.Value);
                edit.IsMale = chkIsMale.Checked;
                edit.CountryID = cmbCountries.SelectedIndex + 1;
                string newImagePath = null;
                if (SaveImage(ref newImagePath, oldImagePath))
                    edit.ImagePath = newImagePath;
                else
                {
                    clsUtilty.PrintWarn("Error while saving user image");
                    return;
                }

                try
                {

                    bool res = await clsPerson.EditPersonData(edit);

                    if (res)
                    {
                        ChangeModeToEdit(false);
                        btnEdit.Text = "Edit Profile";
                        SaveCurrentUserData(edit);
                        SendPersonSummary(edit);
                    }
                    else
                    {
                        if (edit.ImagePath != null)
                            File.Delete(edit.ImagePath);

                        clsUtilty.PrintWarn("Error while saving the data, plases try again later");
                    }
                }
                catch (Exception ex)
                {
                    clsUtilty.PrintWarn("Error: " + ex.Message);
                }
            }
        }

        void SendPersonSummary(DTO_PersonEdit edit)
        {
            DTO_PersonSummary summary = new DTO_PersonSummary();
            summary.Address = edit.Address;
            summary.PersonId = edit.PersonID;
            summary.CountryId = edit.CountryID;
            summary.Email = edit.Email;
            summary.FirstName = edit.FirstName;
            summary.LastName = edit.LastName;
            summary.Phone = edit.PhoneNumber;
            summary.BirthDate = edit.BirthDate;
            summary.UserImagePath = edit.ImagePath;

            summary.IsMale = edit.IsMale;

            if(_person != null)
            {
                summary.IsActive = _person.IsActive;
                summary.IsAdmin = _person.IsAdmin;
                summary.IsSeller = _person.IsSeller; 
            }
            else
            {
                summary .IsActive = true;
                summary .IsAdmin = false;
                summary .IsSeller = false;
            }

            OnSave?.Invoke(summary);
        }

        void SendPersonSummary(DTO_PersonCreate edit,int personId)
        {
            DTO_PersonSummary summary = new DTO_PersonSummary();
            summary.Address = edit.Address;
            summary.PersonId = personId;
            summary.CountryId = edit.CountryId;
            summary.Email = edit.Email;
            summary.FirstName = edit.FirstName;
            summary.LastName = edit.LastName;
            summary.Phone = edit.Phone;
            summary.BirthDate = edit.BirthDate;
            summary.UserImagePath = edit.ImagePath;

            summary.IsMale = edit.IsMale;

            if (_person != null)
            {
                summary.IsActive = _person.IsActive;
                summary.IsAdmin = _person.IsAdmin;
                summary.IsSeller = _person.IsSeller;
            }
            else
            {
                summary.IsActive = true;
                summary.IsAdmin = false;
                summary.IsSeller = false;
            }

            OnSave?.Invoke(summary);
        }


        async Task SaveNewUser()
        {
            if (await CheckCondetions(true))
            {
                DTO_PersonCreate newPerson = new DTO_PersonCreate();
                newPerson.FirstName = tbxFirstName.Text;
                newPerson.LastName = tbxSecondName.Text;
                newPerson.Address = tbxAddress.Text;
                newPerson.Email = tbxEmail.Text;
                newPerson.Phone = tbxPhone.Text;
                newPerson.BirthDate = DateOnly.FromDateTime(dtpBirthdate.Value);
                newPerson.IsMale = chkIsMale.Checked;
                newPerson.CountryId = cmbCountries.SelectedIndex + 1;
                newPerson.Password = "1234";
                string newImagePath = null;
                if (SaveImage(ref newImagePath,null))
                    newPerson.ImagePath = newImagePath;
                else
                {
                    clsUtilty.PrintWarn("Error while saving user image");
                    return;
                }

                try
                {

                    int id = await clsAdmin.CreateNewPerson(newPerson);

                    if (id > 0)
                    {
                        btnEdit.Text = "Edit Person";

                        SendPersonSummary(newPerson, id);

                        _SetForAddUser = false;
                        return;
                    }
                    else
                    {
                        if(newPerson.ImagePath!= null)
                        File.Delete(newPerson.ImagePath);

                        clsUtilty.PrintWarn("Error while saving the data, plases try again later");
                    }
                }
                catch (Exception ex)
                {
                    clsUtilty.PrintWarn("Error: " + ex.Message);
                }





            }
        }

        async Task<bool> CheckCondetions(bool SkipMatch = false)
        {
            if (!string.IsNullOrWhiteSpace(tbxSecondName.Text) && !string.IsNullOrWhiteSpace(tbxFirstName.Text) && !string.IsNullOrWhiteSpace(tbxPhone.Text) && !string.IsNullOrWhiteSpace(tbxAddress.Text))
            {

                if (!IsValidEmail())
                {
                    clsUtilty.PrintWarn("email is not accepted");
                    return false;
                }

                if(SkipMatch)
                {
                    if (await IsEmailRegisteredByAnyOne())
                    {
                        clsUtilty.PrintWarn("email is used, please change it");
                        return false;
                    }

                    if (await IsPhoneRegisteredByAnyOne())
                    {
                        clsUtilty.PrintWarn("phone is used, please change it");
                        return false;
                    }
                }
                else
                {
                    if (await IsEmailRegisteredByAnotherPerson())
                    {
                        clsUtilty.PrintWarn("email is used, please change it");
                        return false;
                    }

                    if (await IsPhoneRegisteredByAnotherPerson())
                    {
                        clsUtilty.PrintWarn("phone is used, please change it");
                        return false;
                    }
                }
              
            }
            else
            {
                clsUtilty.PrintWarn("Please fill the data");
                return false;
            }

            return true;
        }

        bool IsValidEmail()
        {
            return MailAddress.TryCreate(tbxEmail.Text, out _);
        }

        bool SaveImage(ref string? newImagePath,string? oldPath)
        {
            if (picUserPic.ImageLocation != oldPath)
            {

                if (picUserPic.ImageLocation != null)
                    if (!clsUtilty.SaveImageToFileWithGuid(picUserPic.ImageLocation, ref newImagePath, true))
                        return false;


                    if (oldPath != null)
                        File.Delete(oldPath);


                oldPath = newImagePath;
            }

            newImagePath = oldPath;

            return true;
        }

        async Task<bool> IsEmailRegisteredByAnotherPerson()
        {
            if (email != tbxEmail.Text)
                return await clsPerson.IsEmailRegisteredByAnotherPerson(tbxEmail.Text,_personId);

            return false;
        }

        async Task<bool> IsPhoneRegisteredByAnotherPerson()
        {
            if (phone != tbxPhone.Text)
                return await clsPerson.IsPhoneRegisteredByAnotherPerson(tbxPhone.Text,_personId);

            return false;
        }
        async Task<bool> IsPhoneRegisteredByAnyOne()
        {
          return await clsPerson.IsPhoneRegisteredByAnyOne(tbxPhone.Text);
        }
        async Task<bool> IsEmailRegisteredByAnyOne()
        {
          return await clsPerson.IsEmailRegisteredByAnyOne(tbxEmail.Text);
        }

        void SaveCurrentUserData(DTO_PersonEdit newData)
        {
            if(newData.PersonID == clsDefultes.LogendUser.person.PersonId)
            {
                clsDefultes.LogendUser.person.BirthDate = newData.BirthDate;
                clsDefultes.LogendUser.person.FirstName = newData.FirstName;
                clsDefultes.LogendUser.person.LastName = newData.LastName;
                clsDefultes.LogendUser.person.IsMale = newData.IsMale;
                clsDefultes.LogendUser.person.ImagePath = newData.ImagePath;
                clsDefultes.LogendUser.person.Address = newData.Address;
                clsDefultes.LogendUser.person.Phone = newData.PhoneNumber;
                clsDefultes.LogendUser.person.CountryName = cmbCountries.SelectedItem.ToString();
            }
            
        }

        private void pbBtnChangePic_Click(object sender, EventArgs e)
        {
            if (_inSaveMode)
            {
                ChangePic();
            }

        }

        void ChangePic()
        {

            openFileDialog1.Filter =
                "Image Files|*.jpg;*.jpeg;*.png;";

            openFileDialog1.Title = "Select Picture";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picUserPic.ImageLocation = openFileDialog1.FileName;
                llblRemoveImage.Visible = true;
                llblRemoveImage.Enabled = true;
            }

        }

        private void tbxPhone_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void uctrlUserDetailsRowsWithEdit_Load(object sender, EventArgs e)
        {

        }

        private void lnlRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picUserPic.ImageLocation = null;
            clsUtilty.LoadUserImage(ref picUserPic, null, clsDefultes.LogendUser.person.IsMale);
            llblRemoveImage.Visible = false;
            llblRemoveImage.Enabled = false;
        }

        private void chkIsMale_Click(object sender, EventArgs e)
        {
            if(!llblRemoveImage.Visible)
            {
                clsUtilty.LoadUserImage(ref picUserPic, clsDefultes.LogendUser.person.ImagePath, chkIsMale.Checked);
            }

        }
    }
}
