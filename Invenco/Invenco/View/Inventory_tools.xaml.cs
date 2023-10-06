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
using Invenco.ClassImage;
using Invenco.ClassEntity;
using Invenco.Entity;
using System.Drawing;


namespace Invenco.View
{
    /// <summary>
    /// Логика взаимодействия для Inventory_tools.xaml
    /// </summary>
    public partial class Inventory_tools : Window
    {
        

        public Inventory_tools(Person_data person_Data)
        {
            InitializeComponent();

            
            
            PhotoEllipse.ImageSource = AddImage.ByteToArrayToImage(person_Data.Image, person_Data);

            ConnectEntity.PersonData(person_Data, FullName_tb, FullPatronymic, AddFullPersonDataBt);

            ConnectEntity.person_Data=person_Data;

            
            
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
            if(e.ChangedButton==MouseButton.Left)
            {
                
             AddImage.AddImageProfile(PhotoEllipse, "PNG(*.png)|*.png|JPG(*.jpg)|*.jpg|JPEG(*.jpeg)|*.jpeg", ConnectEntity.person_Data);

            }
            
        }

        private void Invertarization_Btn_Click(object sender, RoutedEventArgs e)
        {
            new Inventarization().Show();
            Hide();
        }

        private void EditingImage_Click(object sender, RoutedEventArgs e)
        {
            new PictureEditor(ConnectEntity.person_Data).Show();
            Hide();
        }

        private void DeletePhoto_Click(object sender, RoutedEventArgs e)
        {
            PhotoEllipse.ImageSource = DeleteImage.DeleteImages(ConnectEntity.person_Data, PhotoEllipse);
           
        }

        private void AddFullPersonData_Click(object sender, RoutedEventArgs e)
        {
            new Person_data_profile(ConnectEntity.person_Data).Show();
            Hide();
        }

        private void Back_Left_chefron_BT_Click(object sender, RoutedEventArgs e)
        {
            new Avtorization().Show();
            Hide();
        }

        private void Map_Btn_Click(object sender, RoutedEventArgs e)
        {
            new Map().Show();
            Hide();
        }

        private void HistoryLog_Click(object sender, RoutedEventArgs e)
        { 
            new HistoryInvertarization().Show();
            Hide();

        }
    }
}
