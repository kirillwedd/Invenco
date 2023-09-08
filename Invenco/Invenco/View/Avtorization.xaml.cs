﻿using System;
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
    /// Логика взаимодействия для Avtorization.xaml
    /// </summary>
    public partial class Avtorization : Window
    {
        public Avtorization()
        {
            InitializeComponent();
        }

        private void AddUserImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            new Registration2().Show();
            Hide();
        }

        private void BackSpace_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
               ClassBackSpace.BackSpaceImage(PasswordBox, Password_TB);

            }
        }

        private void AvtorizationBt_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassClear.ClearsTextBox(AvtGrid);
            ClassClear.ClearsPasswordBox(AvtGrid);
        }

        private void Roll_up_Bt_Click(object sender, RoutedEventArgs e)
        {
            WindowsControls.Roll_Up_Mt(this);

        }

        private void ClosesBt_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
