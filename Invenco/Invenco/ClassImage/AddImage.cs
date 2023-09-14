using Invenco.ClassEntity;
using Invenco.ClassTransmitted;
using Invenco.View;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.Adapters;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Invenco.ClassImage
{
    static class AddImage
    {
        public static byte[] Photo { get; set; }      

        public static void AddImageProfile(ImageBrush image, string _filter)
        {

            try
            {
                OpenFileDialog create = new OpenFileDialog();
                create.Filter = _filter;
                if (create.ShowDialog() == true)
                {
                    image.ImageSource = new BitmapImage(new Uri(create.FileName));
                    ImageTransmitted.Image = image.ImageSource;

                }
                byte[] bytes = File.ReadAllBytes(create.FileName);
                Photo = bytes;
                new PictureEditor().Show();
                new Inventory_tools(ConnectEntity.person_Data).Hide();
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
