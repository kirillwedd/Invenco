using Invenco.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Invenco.ClassEntity;
using System.Windows.Media;

namespace Invenco.ClassImage
{
    static class LoadImage
    {

        public static void LoadImageByte(ImageBrush imageBrush)
        {
            BitmapImage bitmap = new BitmapImage();
            using(MemoryStream memory = new MemoryStream(ConnectEntity.person_Data.Image))
            {
                bitmap.BeginInit();
                bitmap.CacheOption= BitmapCacheOption.OnLoad;
                bitmap.StreamSource= memory;
                bitmap.EndInit();
                imageBrush.ImageSource = bitmap;
            }
        }
      
    }
}
