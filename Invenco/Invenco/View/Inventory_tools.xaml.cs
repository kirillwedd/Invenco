using MaterialDesignThemes.Wpf;
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
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;
using Invenco.Class;
using Invenco.ClassTransmitted;

namespace Invenco.View
{
    /// <summary>
    /// Логика взаимодействия для Inventory_tools.xaml
    /// </summary>
    public partial class Inventory_tools : Window
    {
        public Inventory_tools()
        {
            InitializeComponent();
            PhotoEllipse.ImageSource = ImageTransmitted.Image;
            
        }

        private void Deployment_Icon_Click(object sender, RoutedEventArgs e)
        {
            WindowsControls.DeploymentMT(this);
        }

        private void ClosesBt_Click(object sender, RoutedEventArgs e)
        {
           Close();
        }

        private void Roll_up_Bt_Click(object sender, RoutedEventArgs e)
        {
            WindowsControls.Roll_Up_Mt(this);
        }

       

        private void EllipcePhoto_MouseDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog create = new OpenFileDialog();
            create.Filter = "PNG(*.png)|*.png|JPG(*.jpg)|*.jpg|JPEG(*.jpeg)|*.jpeg";
            if (create.ShowDialog() == true)
            {
                PhotoEllipse.ImageSource = new BitmapImage(new Uri(create.FileName));
                ImageTransmitted.Image = PhotoEllipse.ImageSource;
                

            }
            new PictureEditor().Show();
            
        }

        private void Invertarization_Btn_Click(object sender, RoutedEventArgs e)
        {
            new Map().Show();
            Hide();
        }
    }
}
