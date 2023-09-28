using Invenco.Class;
using Invenco.ClassImage;
using Invenco.MapsClass;
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

namespace Invenco.View
{
    /// <summary>
    /// Логика взаимодействия для AddMarker.xaml
    /// </summary>
    public partial class AddMarker : Window
    {
        public AddMarker()
        {
            InitializeComponent();
            MapsEntity.LoadedSource(Category_CB, StatusNameCB);
            MapsEntity.BlokesDate(DateEnd_DataPicker);
            
            
         
        }

        private void ClosesBt_Click(object sender, RoutedEventArgs e)
        {
            MapsEntity.DeleteMarker(MapsEntity.control);
            Close();
        }

        private void Roll_up_Bt_Click(object sender, RoutedEventArgs e)
        {
            WindowsControls.Roll_Up_Mt(this);
        }

        private void AddMarker1_Click(object sender, RoutedEventArgs e)
        {
            AddImage.StubImage(InvenatarizationImage);
            MapsEntity.AddMarker(NameInvertarizationTB, InvertNumberTB, Category_CB, cabinetTB, StatusNameCB, DateEnd_DataPicker, InvenatarizationImage);         
            Hide();
        }

        private void InvenatarizationImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AddImage.AddImageProfile(InvenatarizationImage, "PNG(*.png)|*.png|JPG(*.jpg)|*.jpg|JPEG(*.jpeg)|*.jpeg" );
            
        }

       
    }
}
