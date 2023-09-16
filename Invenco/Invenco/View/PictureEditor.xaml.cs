using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;
using Invenco.Class;
using Invenco.ClassTransmitted;
using Invenco.ClassEntity;
using Invenco.ClassImage;
using Invenco.Entity;
using System.IO;

namespace Invenco.View
{
    /// <summary>
    /// Логика взаимодействия для PictureEditor.xaml
    /// </summary>
    public partial class PictureEditor : Window
    {
        private Point startPoint;
        private bool isDragging = false;

        private Person_data Person_Data;


        public PictureEditor(Person_data _Data)
        {
            InitializeComponent();         
             
            _Data.PersonID = ConnectEntity.person_Data.PersonID;
            _Data.Login = ConnectEntity.person_Data.Login;
            _Data.Password=ConnectEntity.person_Data.Password;
            _Data.Name= ConnectEntity.person_Data.Name;
            _Data.LastName= ConnectEntity.person_Data.LastName;
            _Data.Patronymic=ConnectEntity.person_Data.Patronymic;
            PhotoImage.Source = AddImage.ByteToArrayToImage(_Data.Image, _Data);
            Person_Data= _Data;
        }

        private void Roll_up_Bt_Click(object sender, RoutedEventArgs e)
        {
            WindowsControls.Roll_Up_Mt(this);
        }

        private void Deployment_Icon_Click(object sender, RoutedEventArgs e)
        {
            WindowsControls.DeploymentMT(this);
        }

        private void ClosesBt_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

       

       

        
        private void SaveChengesBt_Click(object sender, RoutedEventArgs e)
        {
            double scaleX = PhotoImage.ActualWidth / PhotoImage.Source.Width;
            double scaleY = PhotoImage.ActualHeight / PhotoImage.Source.Height;

            double cropLeft = Math.Max(0, Canvas.GetLeft(CropRectangle) / scaleX);
            double cropTop = Math.Max(0, Canvas.GetTop(CropRectangle) / scaleY);
            double cropWidth = CropRectangle.Width / scaleX;
            double cropHeight = CropRectangle.Height / scaleY;

            try
            {
                CroppedBitmap croppedBitmap = new CroppedBitmap((BitmapSource)PhotoImage.Source, new Int32Rect((int)cropLeft, (int)cropTop, (int)cropWidth, (int)cropHeight));
                PhotoImage.Source = croppedBitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка обрезки изображения: " + ex.Message);
            }

            CropRectangle.Visibility = Visibility.Collapsed;
            isDragging = false;


            ImageTransmitted.Image = PhotoImage.Source;

            

            var chengePerson_Data = ConnectEntity.db.Person_data
                .Where(x => x.PersonID == Person_Data.PersonID && x.Login == Person_Data.Login && x.Password == Person_Data.Password
                && x.Name == Person_Data.Name && x.LastName==Person_Data.LastName && x.Patronymic == Person_Data.Patronymic).FirstOrDefault();

            chengePerson_Data.PersonID=Person_Data.PersonID;
            chengePerson_Data.Login=Person_Data.Login;
            chengePerson_Data.Password=Person_Data.Password;
            chengePerson_Data.Name=Person_Data.Name;
            chengePerson_Data.LastName=Person_Data.LastName;
            chengePerson_Data.Patronymic=Person_Data.Patronymic;
            chengePerson_Data.Image =LoadImage.PictureEditorUpdateImage(PhotoImage.Source as CroppedBitmap);

            
            ConnectEntity.db.SaveChanges();
            new Inventory_tools(ConnectEntity.person_Data).Show();
            Hide();
        }

        private void CropCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentPoint = e.GetPosition(CropCanvas);
                double minX = Math.Min(startPoint.X, currentPoint.X);
                double minY = Math.Min(startPoint.Y, currentPoint.Y);
                double maxX = Math.Max(startPoint.X, currentPoint.X);
                double maxY = Math.Max(startPoint.Y, currentPoint.Y);

                Canvas.SetLeft(CropRectangle, minX);
                Canvas.SetTop(CropRectangle, minY);
                CropRectangle.Width = maxX - minX;
                CropRectangle.Height = maxY - minY;
            }

        }

        private void CropCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            isDragging = false;
        }

        private void ImagePhoto_MouseDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(CropCanvas);
            Canvas.SetLeft(CropRectangle, startPoint.X);
            Canvas.SetTop(CropRectangle, startPoint.Y);
            CropRectangle.Width = 0;
            CropRectangle.Height = 0;
            CropRectangle.Visibility = Visibility.Visible;

            isDragging = true;
        }

        private void ImagePhoto_MouseUp(object sender, MouseButtonEventArgs e)
        {
            isDragging = false;
        }

        private void PhotoImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(PhotoImage);
            Canvas.SetLeft(CropRectangle, startPoint.X);
            Canvas.SetTop(CropRectangle, startPoint.Y);
            CropRectangle.Width = 0;
            CropRectangle.Height = 0;
            CropRectangle.Visibility = Visibility.Visible;

            isDragging = true;
        }

        private void PhotoImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentPoint = e.GetPosition(PhotoImage);
                double minX = Math.Min(startPoint.X, currentPoint.X);
                double minY = Math.Min(startPoint.Y, currentPoint.Y);
                double maxX = Math.Max(startPoint.X, currentPoint.X);
                double maxY = Math.Max(startPoint.Y, currentPoint.Y);

                double width = maxX - minX;
                double height = maxY - minY;

                CropRectangle.Width = width;
                CropRectangle.Height = height;

                Canvas.SetLeft(CropRectangle, minX);
                Canvas.SetTop(CropRectangle, minY);
            }
        }

        private void PhotoImage_MouseUp(object sender, MouseButtonEventArgs e)
        {

            isDragging = false;
        }

        private void ImageSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (PhotoImage.Source != null)
            {
                double scale = ImageSlider.Value;

                PhotoImage.Width = PhotoImage.Source.Width * scale;
                PhotoImage.Height = PhotoImage.Source.Height * scale;
            }
        }
    }
}
