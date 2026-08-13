using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CredentialManagement;
using StoreHub_Desktop.Properties;
namespace StoreHub_Desktop.Classes
{
    public class clsUtilty
    {

        public static void PrintWarn(string msg)
        {
            MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void PrintInfo(string msg)
        {
            MessageBox.Show(msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void SetUserImage(ref Guna2CirclePictureBox pictureBox,string imagePath,bool isMale)
        {
            if(File.Exists(imagePath))
            {
                pictureBox.ImageLocation = imagePath;
            }
            else
            {
                if(isMale)
                {

                }
                else
                {

                }
            }
        }

        public static void SetProductImage(ref Guna2PictureBox pictureBox, string imagePath)
        {
            if (File.Exists(imagePath))
            {
                pictureBox.ImageLocation = imagePath;
            }
            else
            {
                pictureBox.Image = Resources.ChatGPT_Image_Aug_10__2026__09_58_47_PM;
            }
        }


        public static void SaveEmailPasswordInCMW(string email,string password)
        {
            var credential = new Credential
            {
                Target = "StoreHub",
                Username = email,
                Password = password,
                Type = CredentialType.Generic
            };

            credential.Save();
        }


        public static (string email, string password) LoadEmailPasswordFromCMW()
        {
            var credential = new Credential
            {
                Target = "StoreHub",
                Type = CredentialType.Generic
            };

            if (!credential.Load())
                return (string.Empty, string.Empty);

            return (credential.Username ?? string.Empty, credential.Password ?? string.Empty);
        }

        public static void DeleteEmailPasswordFromCMW()
        {
            var credential = new Credential
            {
                Target = "StoreHub",
                Type = CredentialType.Generic
            };

            credential.Delete();

        }
    }
}
