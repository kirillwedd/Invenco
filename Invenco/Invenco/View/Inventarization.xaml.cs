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
            // Журнал перемещений
        }      

        private void AddInvertarization_Click(object sender, RoutedEventArgs e)
        {
            int countsTextboxCount = AddEntityInvertarization.CountTextBoxesStackPanel(MainStackPanel);
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

        }

        private void KategoryStatus_Bt_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
