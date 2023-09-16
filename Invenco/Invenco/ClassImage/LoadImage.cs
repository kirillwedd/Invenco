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
using System.Drawing;
using System.Windows.Controls;

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

        public static byte[] PictureEditorUpdateImage(CroppedBitmap _image)
        {
            MemoryStream memStream = new MemoryStream();
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(_image));
            encoder.Save(memStream);
            return memStream.ToArray();
        }
      
    }
}
