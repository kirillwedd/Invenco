using Invenco.ClassEntity;
using Invenco.ClassTransmitted;
using Invenco.Entity;
using Invenco.View;
using MahApps.Metro.IconPacks;
using MaterialDesignThemes.Wpf;
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
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using MaterialDesignThemes.Wpf.Converters;
using System.Globalization;
using ImageProcessor.Processors;
using MahApps.Metro.Controls;
using System.Drawing.Imaging;
using System.Runtime.InteropServices.ComTypes;



namespace Invenco.ClassImage
{
    static class AddImage
    {
        public static byte[] Photo { get; set; }
        public static Geometry Geometry { get; private set; }
      

        private static Person_data Person_Data;

        public static void AddImageProfile(ImageBrush image, string _filter, Person_data person)
        {
            person.PersonID = ConnectEntity.person_Data.PersonID;
            person.Login = ConnectEntity.person_Data.Login;
            person.Password = ConnectEntity.person_Data.Password;
            person.Name = ConnectEntity.person_Data.Name;
            person.LastName = ConnectEntity.person_Data.LastName;
            person.Patronymic = ConnectEntity.person_Data.Patronymic;
            person.Image = ConnectEntity.person_Data.Image;

            Person_Data = person;
            
                OpenFileDialog create = new OpenFileDialog();
                create.Filter = _filter;
                if (create.ShowDialog() == true)
                {
                    image.ImageSource = new BitmapImage(new Uri(create.FileName));
                    ImageTransmitted.Image = image.ImageSource;

                }
                byte[] bytes = File.ReadAllBytes(create.FileName);
                Photo = bytes;

                var chengePerson_Data = ConnectEntity.db.Person_data
                 .Where(x => x.PersonID == Person_Data.PersonID && x.Login == Person_Data.Login && x.Password == Person_Data.Password
                 && x.Name == Person_Data.Name && x.LastName == Person_Data.LastName && x.Patronymic == Person_Data.Patronymic
                 ).FirstOrDefault();

                chengePerson_Data.PersonID = person.PersonID;
                chengePerson_Data.Login = person.Login;
                chengePerson_Data.Password = person.Password;
                chengePerson_Data.Name = person.Name;
                chengePerson_Data.LastName = person.LastName;
                chengePerson_Data.Patronymic = person.Patronymic;
                chengePerson_Data.Image =Photo;
                ConnectEntity.db.SaveChanges();

            
           
        }


        public static void AddImageProfile( System.Windows.Controls.Image image, string _filter)
        {
            try
            {
                OpenFileDialog create = new OpenFileDialog();
                create.Filter = _filter;
                if (create.ShowDialog() == true)
                {
                    image.Source = new BitmapImage(new Uri(create.FileName)); 
                    byte[] bytes = File.ReadAllBytes(create.FileName);
                    Photo = bytes;


                }
               
              
            }
            catch
            {
            }
        }
        

       


        public static void StubImage(System.Windows.Controls.Image image)
        {
            string expectedImagePath = "pack://application:,,,/Image/AddToList.png";

            var bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(expectedImagePath, UriKind.RelativeOrAbsolute);
            bitmapImage.EndInit();

            if (image.Source.ToString()==expectedImagePath.ToString()) 
            {
                image.Source = new BitmapImage(new Uri("\\Image\\StubImage.png", UriKind.RelativeOrAbsolute));
                byte[] imageBytes;

                ImageSource imageSource = image.Source;
                using (MemoryStream stream = new MemoryStream())
                {
                    BitmapFrame bitmapFrame = BitmapFrame.Create((BitmapSource)imageSource);
                    BitmapEncoder bitmapEncoder = new PngBitmapEncoder();
                    bitmapEncoder.Frames.Add(bitmapFrame);
                    bitmapEncoder.Save(stream);
                    imageBytes = stream.ToArray();
                    Photo = imageBytes;
                }
            }
        }

        public static  BitmapSource ByteToArrayToImage(byte[] buffer, Person_data person_Data)
        {
            if (person_Data.Image != null)
            {
                using (var Stream = new MemoryStream(buffer))
                {
                    return BitmapFrame.Create(Stream, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
                }
                
            }
            return null;
        }

        public static BitmapSource ByteToArrayToImageInvertarization(byte[] buffer)
        {
            
                using (var Stream = new MemoryStream(buffer))
                {
                    return BitmapFrame.Create(Stream, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
                }

            
          
        }

    }

}
