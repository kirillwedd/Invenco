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
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Wpf;
using GMap.NET.MapProviders;
using GMap.NET.WindowsPresentation;
using Newtonsoft.Json;
using GMap.NET;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using System.Security.Cryptography.X509Certificates;
using GMap.NET.WindowsForms.Markers;
using Invenco.ClassTransmitted;
using MahApps.Metro.Controls;

namespace Invenco.View
{
    /// <summary>
    /// Логика взаимодействия для Map.xaml
    /// </summary>
    public partial class Map : Window
    {
     
        
        public Map()
        {
            InitializeComponent();
            
           

        }

        private void ClosesBt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Roll_up_Bt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Deployment_Icon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Invertarization_Btn_Click(object sender, RoutedEventArgs e)
        {

        }
        
        private void EllipcePhoto_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void GMapControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Maps_Loaded(object sender, RoutedEventArgs e)
        {
            Maps.MinZoom = 5;
            Maps.MaxZoom = 20;
            Maps.Zoom = 15;
            Maps.MapProvider = GMapProviders.GoogleMap;
            Maps.DragButton = MouseButton.Left;
            Maps.Position =new PointLatLng(55.344181, 61.338637);
            GMapProvider.Language = LanguageType.Russian;

            

           
            
        }

        private void Maps_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton==MouseButton.Right)
            {
               
                double X = Maps.FromLocalToLatLng(System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y).Lng;
                double Y = Maps.FromLocalToLatLng(System.Windows.Forms.Control.MousePosition.X, System.Windows.Forms.Control.MousePosition.Y).Lat;
            
                System.Windows.MessageBox.Show($"Координаты: {Math.Round(Y, 6)}, {Math.Round(X, 6)}", "Координаты");

                Coordinates.Y = Y;
                Coordinates.X = X;

                
            }

            if(e.ChangedButton==MouseButton.Left)
            {
                 GMapMarker gMarker = new GMapMarker(new PointLatLng(Coordinates.Y, Coordinates.X));
                 Maps.Markers.Add(gMarker);
                
            }
        }
    }
}
