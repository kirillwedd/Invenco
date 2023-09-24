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
using MaterialDesignThemes.Wpf;
using Invenco.Class;
using System.Data.SqlClient;
using System.Data;
using Invenco.MapsClass;
using Invenco.Entity;
using Invenco.ClassEntity;

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

            Loaded += Maps_Loaded;
            
            

        }

        private void ClosesBt_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Roll_up_Bt_Click(object sender, RoutedEventArgs e)
        {
            WindowsControls.Roll_Up_Mt(this);
        }

        private void Deployment_Icon_Click(object sender, RoutedEventArgs e)
        {
            WindowsControls.DeploymentMT(this);
        }

        private void Invertarization_Btn_Click(object sender, RoutedEventArgs e)
        {

        }
        
        private void EllipcePhoto_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
        }

       
        private void Maps_Loaded(object sender, RoutedEventArgs e)
        {
            Maps.MinZoom = 5;
            Maps.MaxZoom = 30;
            Maps.Zoom = 15;
            Maps.MapProvider = GMapProviders.GoogleMap;
            Maps.DragButton = MouseButton.Left;
            Maps.Position =new PointLatLng(55.344181, 61.338637);
            GMapProvider.Language = LanguageType.Russian;
            LoadMarkers();
                    
            
        }

        private void Maps_MouseDoubleClick(object sender, MouseButtonEventArgs e) // Добавление метки
        {

            if (e.ChangedButton == MouseButton.Left)
            {

                double latitude = Maps.Position.Lat;
                double longitude = Maps.Position.Lng;

                Coordinates.X = latitude;
                Coordinates.Y = longitude;


                GMapMarker gMarker = new GMapMarker(new PointLatLng(latitude, longitude));


                gMarker.Shape = new Image()
                {
                    Source = new BitmapImage(new Uri("C:\\Users\\1\\Desktop\\Pet_Project\\Invenco\\Invenco\\Image\\MarkerCheck.png")),
                    Width = 20,
                    Height = 20,
                    ToolTip = 
                    Visibility = Visibility.Visible,
                    

                };
                Maps.Markers.Add(gMarker);
                MapsEntity.GMapMarker = gMarker;
                MapsEntity.control = Maps;

                new AddMarker().ShowDialog();

                
            }

           
        }

        private  void ClearMarkers()
        {
            Maps.Markers.Clear();
            
        }

        private  void LoadMarkers()
        {



            ClearMarkers();

            string query = "Select Invertarization.name, Latitude, Longitude, cabinet from Markers Join Invertarization on Invertarization.MarkersID=Markers.MarkerID";

            using (SqlConnection connection = new SqlConnection(MapsEntity.connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    double latitude = (double)row["Latitude"];
                    double longitude = (double)row["Longitude"];
                    string name = (string)row["Name"];
                    string cabinet = (string)row["cabinet"];

                    System.Windows.Controls.ToolTip toolTip = new System.Windows.Controls.ToolTip();
                    StackPanel stackPanelToolTip = new StackPanel();
                    stackPanelToolTip.Children.Add(new System.Windows.Controls.TextBlock { Text = name });
                    stackPanelToolTip.Children.Add(new System.Windows.Controls.TextBlock { Text = cabinet  });
                    toolTip.Content = stackPanelToolTip;

                    var marker = new GMapMarker(new PointLatLng(latitude, longitude))
                    {
                        Shape= new Image()
                        {
                            Source = new BitmapImage(new Uri("C:\\Users\\1\\Desktop\\Pet_Project\\Invenco\\Invenco\\Image\\MarkerCheck.png")),
                            Width = 20,
                            Height = 20,
                            ToolTip = toolTip,
                            Visibility = Visibility.Visible,
                        }
                        
                    };
                    Maps.Markers.Add(marker);

                    
                    
                    

                  

                    
                }

            }
            
        }

        private void AddMarker()
        {
            double latitude = Maps.Position.Lat;
            double longitude = Maps.Position.Lng;
            string name = "Маркер";

            string query = "INSERT INTO Markers (Latitude, Longitude, Name) VALUES (@Latitude, @Longitude, @Name)";

            using (SqlConnection connection = new SqlConnection(MapsEntity.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("MarkerID", ConnectEntity.CountMarkers);
                command.Parameters.AddWithValue("Latitude", latitude);
                command.Parameters.AddWithValue("Longitude", longitude);
                command.Parameters.AddWithValue("Name", name);

                command.ExecuteNonQuery();
            }

        }


      

       

    }
}
