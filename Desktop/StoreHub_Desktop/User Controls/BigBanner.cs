using StoreHub_Desktop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreHub_Desktop.User_Controls
{
    public partial class BigBanner : UserControl
    {


        public enum EBannars
        {

            Electornics = 0,
            Clothes = 1,
            furniture = 2,
            Books = 3

        }

        public EBannars BannarImage { get { return _image; } set { _image = value; ChangeBannerImage(); } }

        private EBannars _image;

        public bool SetAutomaticChanges { get { return _Auto; } set { _Auto = value; SetAutamticChanges(); } }

        bool _Auto = false;

        int _imageCount { get { return _imageCountGet; } set { BannarImage = (EBannars)value; _imageCountGet = value; } }

        private int _imageCountGet;


        public BigBanner()
        {
            InitializeComponent();
        }



        void ChangeBannerImage()
        {

            switch (_image)
            {
                case EBannars.Electornics:
                    pbImage.Image = Resources.Bannar1;
                    break;
                case EBannars.furniture:
                    pbImage.Image = Resources.BannarFirnotion;

                    break;
                case EBannars.Clothes:
                    pbImage.Image = Resources.BannarClothes;

                    break;
                case EBannars.Books:
                    pbImage.Image = Resources.BannarBooks2;

                    break;
                default:
                    pbImage.Image = Resources.Bannar1;
                    break;
            }


        }


        public void SetAutamticChanges()
        {
            if (SetAutomaticChanges)
                timer1.Start();
            else
                timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_Auto)
            {
                _imageCount++;

                if (_imageCount >= Enum.GetValues<EBannars>().Length)
                {
                    _imageCount = 0;
                }
            }
        }
    }
}
