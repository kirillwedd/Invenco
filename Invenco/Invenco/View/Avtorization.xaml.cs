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
using Invenco.ClassAvtrorization;
using Invenco.ClassEntity;

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
            MediaBackground.Play();
            MediaBackground.MediaEnded += MediaBackground_MediaEnded;
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
          if(AvtrorizationCS.EntityCheckAvtrorization(LogTB, Password_TB, PasswordBox))
            {
                ConnectEntity.PersonData(LogTB, Password_TB, PasswordBox);
                new Inventory_tools(ConnectEntity.person_Data).Show();
                Hide();
            }
         
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

        private void MediaBackground_MediaEnded(object sender, RoutedEventArgs e)
        {
            MediaBackground.Position = TimeSpan.Zero;
            MediaBackground.Play();
        }
    }
}
