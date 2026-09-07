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

        public static void LoadUserImage(ref Guna2CirclePictureBox pictureBox,string imagePath,bool isMale)
        {
            if(File.Exists(imagePath))
            {
                pictureBox.ImageLocation = imagePath;
            }
            else
            {
                if(isMale)
                {
                    pictureBox.Image = Resources.Male;
                }
                else
                {
                    pictureBox.Image = Resources.Female;
                }
            }
        }

        public static void LoadProductImage( Guna2PictureBox pictureBox, string imagePath)
        {
            if (File.Exists(imagePath))
            {
                pictureBox.ImageLocation = imagePath;
                pictureBox.Visible = true;
            }
            else
            {
                pictureBox.Image = Resources.ChatGPT_Image_Aug_10__2026__09_58_47_PM;
            }
        }

        public static void LoadProductImageFromList(List<Guna2PictureBox> pictureBoxes, List<string> imagePaths)
        {
            for (int i = 0; i < pictureBoxes.Count; i++)
            {
                if (i < imagePaths.Count)
                {
                    LoadProductImage(pictureBoxes[i], imagePaths[i]);
                }
                else
                {
                    return;
                }
            }
        }

        public static void LoadFirstProductImageFromList(Guna2PictureBox pictureBoxe, List<string> imagePaths)
        {
            for (int i = 0; i < imagePaths.Count; i++)
            {
                    LoadProductImage(pictureBoxe, imagePaths[i]);
                    if (pictureBoxe.ImageLocation != null)
                        return;
            }
        }


        public static void SaveEmailPasswordInCMW(string email,string password)
        {
            var credential = new Credential
            {
                Target = "StoreHub",
                Username = email,
                Password = password,
                Type = CredentialType.Generic,
                PersistanceType = PersistanceType.LocalComputer
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











        public static bool SaveImageToFileWithGuid(string imagePath,ref string newImagePath, bool userFolder)
        {

            string guid = Guid.NewGuid().ToString();

            string destnationFolder;
            if (userFolder)
            destnationFolder = @"C:\StoreHub\Images\Users";
            else
                destnationFolder = @"C:\StoreHub\Images\Products";

            if (!CheckPathes(imagePath,destnationFolder))
                return false;


            string newPath = Path.Combine(destnationFolder, guid) + Path.GetExtension(imagePath);


            if(imagePath != null)
            File.Copy(imagePath, newPath);
            newImagePath = newPath;                 

            return true;
        }



        static bool CheckPathes(string imagePath,string folderPath)
        {
           
            if(!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                 return true;
            }

            return true;
        }





    }
}
