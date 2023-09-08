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

namespace Invenco.View
{
    /// <summary>
    /// Логика взаимодействия для Registration2.xaml
    /// </summary>
    public partial class Registration2 : Window
    {
        public Registration2()
        {
            InitializeComponent();
        }

        private void PackIconMaterial_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton==MouseButtonState.Pressed)
            {
                ClassBackSpace.BackSpaceImage(PasswordBox, Password_TB);
            }
        }

        private void ClosesBt_Click(object sender, RoutedEventArgs e)
        {
          this.Close();
        }

        private void Roll_up_Bt_Click(object sender, RoutedEventArgs e)
        {
            WindowsControls.Roll_Up_Mt(this);
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassClear.ClearsTextBox(RegGrid);
            ClassClear.ClearsPasswordBox(RegGrid);
        }

        private void RegistrationBt_Click(object sender, RoutedEventArgs e)
        {
            

           if( LogTB.Rules().MinCharacters(8).IsEmail(LogTB).Validate() && 
             (PasswordBox.Rules().MinCharacters(8).SpecCharactersPasBox(1).CountNumbers(1).Validate()
             || Password_TB.Rules().MinCharacters(8).SpecCharacters(1).CountNumbers(1).Validate()))
            {
                new Registration().Show();
                Hide();
               
                
            }
            
        }

        private void KeyImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            new Avtorization().Show();
            Hide();
        }
       
    }
}
