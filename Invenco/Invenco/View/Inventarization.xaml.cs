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
using Invenco.Class;
using Invenco.ClassEntity;
using Invenco.ClassImage;
using Invenco.ClassInvertarization;

namespace Invenco.View
{
    /// <summary>
    /// Логика взаимодействия для Inventarization.xaml
    /// </summary>
    public partial class Inventarization : Window
    {
        public Inventarization()
        {
            InitializeComponent();
            FullName_tb.Text = ConnectEntity.person_Data.FullName;
            FullPatronymic.Text = ConnectEntity.person_Data.Patronymic;
            PhotoEllipse.ImageSource = AddImage.ByteToArrayToImage(ConnectEntity.person_Data.Image, ConnectEntity.person_Data);
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

        private void Back_Left_chefron_BT_Click(object sender, RoutedEventArgs e)
        {
            new Inventory_tools(ConnectEntity.person_Data).Show();
            Hide();
        }

        private void MapBt_Click(object sender, RoutedEventArgs e)
        {
            new Map().Show();
            Hide();
        }

        private void MovLogBt_Click(object sender, RoutedEventArgs e)
        {
            MovomentLogStack.Visibility = Visibility.Visible;
            Status_CategoryStack.Visibility = Visibility.Hidden;
            InventoryStack.Visibility = Visibility.Hidden;

        }      

        private void AddInvertarization_Click(object sender, RoutedEventArgs e)
        {
            int countsTextboxCount = AddEntityInvertarization.CountTextBoxesStackPanel(Status_CategoryStack);
            if (countsTextboxCount != 2 )
            {

                AddEntityInvertarization.AddInventoryStatus(StatusTB);
                AddEntityInvertarization.AddCategory(CategoryTB);
                AddEntityInvertarization.MessageBuilder();
            }
            else
            {
                AddEntityInvertarization.AddInventoryStatus(StatusTB);
                AddEntityInvertarization.AddCategory(CategoryTB);
                AddEntityInvertarization.MessageBugBuilder();
            }

        }

        private void InventoryLog_Click(object sender, RoutedEventArgs e)
        {
            InventoryStack.Visibility = Visibility.Visible;
            Status_CategoryStack.Visibility = Visibility.Hidden;
            MovomentLogStack.Visibility = Visibility.Hidden;

        }

        private void CategoryStatus_Bt_Click(object sender, RoutedEventArgs e)
        {
            Status_CategoryStack.Visibility = Visibility.Visible;
            InventoryStack.Visibility = Visibility.Hidden;
            MovomentLogStack.Visibility = Visibility.Hidden;
        }

        private void Close_BT_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Inventory_listView_Loaded(object sender, RoutedEventArgs e)
        {
            Inventory_listView.ItemsSource=ConnectEntity.db.Invertarization.ToList();
        }

        private void MovomentLog_ListView_Loaded(object sender, RoutedEventArgs e)
        {
            MovomentLog_ListView.ItemsSource=ConnectEntity.db.MovomentLog.ToList();
        }
    }
}
