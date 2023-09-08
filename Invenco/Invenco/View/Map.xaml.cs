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
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Wpf;
using Newtonsoft.Json;
using Invenco.JSONClass;

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

       

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            await Maps.EnsureCoreWebView2Async(null);

            Maps.CoreWebView2.NavigationCompleted += Maps_NavigationCompleted;
          
            Maps.CoreWebView2.WebMessageReceived += Maps_WebMessageReceived;
        }

        private async void Maps_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            await Maps.CoreWebView2.ExecuteScriptAsync
                ("var marker = new google.maps.Marker({position: {lat: 51.5074, lng: -0.1278}, map: map, title: 'London'})");
        }

        private void Maps_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            var message = JsonSerializer.Deserialize<MyLocation>(e.TryGetWebMessageAsString());

            double latitude = message.Latitude;
            double longitude = message.Longitude;
          


        }

       
    }
}
