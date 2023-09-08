using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;

namespace Invenco.Class
{
    static class ClassBackSpace
    {
        public static void BackSpaceImage( PasswordBox PasswordBox, TextBox Password_TB)
        {
            
                if (Password_TB.Visibility == Visibility.Hidden)
                {
                    Password_TB.Text = PasswordBox.Password;
                    Password_TB.Width = 375;
                    PasswordBox.Width = 0;
                    PasswordBox.Visibility = Visibility.Collapsed;
                    Password_TB.Visibility = Visibility.Visible;
                }
                else if (Password_TB.Visibility == Visibility.Visible)
                {
                    PasswordBox.Password = Password_TB.Text;
                    PasswordBox.Width = 375;
                    Password_TB.Width = 0;
                    Password_TB.Visibility = Visibility.Hidden;
                    PasswordBox.Visibility = Visibility.Visible;
                }

            
        }

    }
}
