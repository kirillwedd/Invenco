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
using Invenco.Entity;


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
           
            MediaBackground.Play(); 
            MediaBackground.MediaEnded += MediaBackground_MediaEnded;
         
            
            
           
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

           if( LogTB.Rules().MinCharacters(8).IsEmail(LogTB).EntityCheckLogin(LogTB).Validate() && PasswordBox.Visibility==Visibility.Visible && 
             (PasswordBox.Rules().MinCharacters(8).SpecCharactersPasBox(1).CountNumbers(1).Validate()))
            {

                ConnectEntity.db.Person_data.Add(new Entity.Person_data()
                {
                    PersonID=ConnectEntity.CountPerson,
                    Login=LogTB.Text,
                    Password = PasswordBox.Password 
                    
                });
                ConnectEntity.db.SaveChanges();

                ConnectEntity.PersonData(LogTB, Password_TB, PasswordBox);

                new Inventory_tools(ConnectEntity.person_Data).Show();
                Hide();
               
                
            }
           else if(LogTB.Rules().MinCharacters(8).IsEmail(LogTB).EntityCheckLogin(LogTB).Validate() && Password_TB.Visibility == Visibility.Visible &&
             (Password_TB.Rules().MinCharacters(8).SpecCharacters(1).CountNumbers(1).Validate()))
            {
                ConnectEntity.db.Person_data.Add(new Entity.Person_data()
                {
                    PersonID = ConnectEntity.CountPerson,
                    Login = LogTB.Text,
                    Password = Password_TB.Text

                });
                ConnectEntity.db.SaveChanges();

                ConnectEntity.PersonData(LogTB, Password_TB, PasswordBox);

                new Inventory_tools(ConnectEntity.person_Data).Show();
                Hide();

            }

        }

        private void KeyImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            new Avtorization().Show();
            Hide();
        }

       

        private void MediaBackground_MediaEnded(object sender, RoutedEventArgs e)
        {
            MediaBackground.Position = TimeSpan.Zero;
            MediaBackground.Play();
        }
    }
}
