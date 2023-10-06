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
using Invenco.ClassImage;
using System.IO;
using System.Windows.Controls.Primitives;
using System.ComponentModel;
using System.Data.Entity;
using System.Runtime.InteropServices.ComTypes;


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
            FullName_tb.Text = ConnectEntity.person_Data.FullName;
            FullPatronymic.Text = ConnectEntity.person_Data.Patronymic;
            PhotoEllipse.ImageSource = AddImage.ByteToArrayToImage(ConnectEntity.person_Data.Image, ConnectEntity.person_Data);

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

            string query = "Select Invertarization.name, Markers.MarkerID, Latitude, Longitude, cabinet, Image_Invertarization  from Markers Join Invertarization on Invertarization.MarkersID=Markers.MarkerID";

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
                    byte[] image = (byte[])row["Image_Invertarization"];
                    int ID = (int)row["MarkerID"];
                   


                    

                    
                    System.Windows.Controls.ToolTip toolTip = new System.Windows.Controls.ToolTip();
                    StackPanel stackPanelMainToolTip = new StackPanel();
                    StackPanel stackPanelImageToolTip  = new StackPanel();
                    StackPanel stackPanelTextToolTip = new StackPanel();
                    stackPanelMainToolTip.Orientation= System.Windows.Controls.Orientation.Horizontal;
                    stackPanelImageToolTip.Orientation=System.Windows.Controls.Orientation.Horizontal;
                    stackPanelTextToolTip.Orientation = System.Windows.Controls.Orientation.Vertical;
                    stackPanelTextToolTip.VerticalAlignment = VerticalAlignment.Center;
                    stackPanelImageToolTip.Children.Add(new Image { Source=AddImage.ByteToArrayToImageInvertarization(image),
                                                                   Height=100, Width=100});
                    stackPanelTextToolTip.Children.Add(new TextBlock { Text = name });
                    stackPanelTextToolTip.Children.Add(new TextBlock { Text= cabinet });
                    stackPanelMainToolTip.Children.Add(stackPanelImageToolTip);
                    stackPanelMainToolTip.Children.Add(stackPanelTextToolTip);
                    toolTip.Content= stackPanelMainToolTip;

                    System.Windows.Controls.ContextMenu menu = new System.Windows.Controls.ContextMenu();
                    System.Windows.Controls.MenuItem menuDelete = new System.Windows.Controls.MenuItem();
                    menuDelete.Tag = ID;
                    menuDelete.Header= "Удалить";
                    menuDelete.Click += MenuDelete_Click;
                    menu.Items.Add(menuDelete);
                    


                    
                  

                    var marker = new GMapMarker(new PointLatLng(latitude, longitude))
                    {
                        Shape = new Image()
                        {
                            Source = new BitmapImage(new Uri("C:\\Users\\1\\Desktop\\Pet_Project\\Invenco\\Invenco\\Image\\MarkerCheck.png")),
                            Width = 20,
                            Height = 20,
                            ToolTip = toolTip,
                            Visibility = Visibility.Visible,
                            ContextMenu=menu,                          
                        }
                        
                        
                    };
                    Maps.Markers.Add(marker);

                   
                    
                }

       
            }
            
        }

        private void MenuDelete_Click(object sender, RoutedEventArgs e)
        {

            
                if (System.Windows.MessageBox.Show("Вы действительно хотите удалить запись.", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    System.Windows.Controls.MenuItem menu = sender as System.Windows.Controls.MenuItem;
                    int MarkerID = (int)menu.Tag;

                    string connectionString = MapsEntity.connectionString;

                    var HistoryMarker = ConnectEntity.db.Markers.FirstOrDefault(m => m.MarkerID == MarkerID);
                    var historyInvertory = ConnectEntity.db.Invertarization.FirstOrDefault(IN => IN.MarkersID == MarkerID);


                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                       
                        string deleteMarkerQuery = "DELETE FROM Markers WHERE MarkerID = @MarkerID";
                        using (SqlCommand command = new SqlCommand(deleteMarkerQuery, connection))
                        {
                            command.Parameters.AddWithValue("@MarkerID", MarkerID);
                            command.ExecuteNonQuery();
                        }

                        string deleteLocationsQuery = "DELETE FROM Invertarization WHERE MarkersID = @MarkersID";
                        using (SqlCommand command = new SqlCommand(deleteLocationsQuery, connection))
                        {
                            command.Parameters.AddWithValue("@MarkersID", MarkerID);
                            command.ExecuteNonQuery();

                        }


                        string InsertHistoryMarker = "INSERT INTO HistoryMarker (HistoryMarkerID, History_Latitude, History_Longitude, History_Name) VALUES (@HistoryMarkerID, @HistoryLatitude, @History_Longitude, @History_Name)";

                        using (SqlCommand InsertCommand = new SqlCommand(InsertHistoryMarker, connection))
                        {
                            InsertCommand.Parameters.AddWithValue("@HistoryMarkerID", HistoryMarker.MarkerID);
                            InsertCommand.Parameters.AddWithValue("@HistoryLatitude", HistoryMarker.Latitude);
                            InsertCommand.Parameters.AddWithValue("@History_Longitude", HistoryMarker.Longitude);
                            InsertCommand.Parameters.AddWithValue("@History_Name", HistoryMarker.Name);
                            InsertCommand.ExecuteNonQuery();

                        }


                        string InsertHistoryInvertarization = "INSERT INTO Inventory_History (History_InventoryID, HistoryMarkerID, Name, Category, StartDate, cabinet, EndDate, StatusName, Image_invertarization) VALUES (@History_InventoryID, @HistoryMarkerID, @Name, @Category, @StartDate, @cabinet, @EndDate, @StatusName, @Image_invertarization)";

                        using (SqlCommand InsertInvertory = new SqlCommand(InsertHistoryInvertarization, connection))
                        {
                            InsertInvertory.Parameters.AddWithValue("@History_InventoryID", historyInvertory.InvertNumber);
                            InsertInvertory.Parameters.AddWithValue("@HistoryMarkerID", HistoryMarker.MarkerID);
                            InsertInvertory.Parameters.AddWithValue("@Name", historyInvertory.name);
                            InsertInvertory.Parameters.AddWithValue("@Category", historyInvertory.Category);
                            InsertInvertory.Parameters.AddWithValue("@StartDate", historyInvertory.StartDate);
                            InsertInvertory.Parameters.AddWithValue("@cabinet", historyInvertory.cabinet);
                            InsertInvertory.Parameters.AddWithValue("@EndDate", historyInvertory.EndDate);
                            InsertInvertory.Parameters.AddWithValue("@StatusName", historyInvertory.StatusName="Списан");
                            InsertInvertory.Parameters.AddWithValue("@Image_invertarization", historyInvertory.Image_Invertarization);
                            InsertInvertory.ExecuteNonQuery();


                        }

                        connection.Close();
                    }
                    System.Windows.MessageBox.Show("Маркер и связанные с ним записи удалены.", "Удаление");
                    LoadMarkers();

                }
            
            
          
           

        }

        private void Back_Left_chefron_BT_Click(object sender, RoutedEventArgs e)
        {
            new Inventory_tools(ConnectEntity.person_Data).Show();
            Hide();
        }
    }


    
}
