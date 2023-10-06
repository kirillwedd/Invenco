using GMap.NET;
using Invenco.ClassImage;
using Invenco.MapsClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
using GMap.NET.WindowsPresentation;
using Invenco.Class;
using Invenco.ClassEntity;
using GMap.NET.MapProviders;

namespace Invenco.View
{
    /// <summary>
    /// Логика взаимодействия для HistoryInvertarization.xaml
    /// </summary>
    public partial class HistoryInvertarization : Window
    {
        public HistoryInvertarization()
        {
            InitializeComponent();

            Loaded += Maps_Loaded;

            FullName_tb.Text = ConnectEntity.person_Data.FullName;
            FullPatronymic.Text = ConnectEntity.person_Data.Patronymic;
            PhotoEllipse.ImageSource = AddImage.ByteToArrayToImage(ConnectEntity.person_Data.Image, ConnectEntity.person_Data);
        }

        private void HistoryInvertory_Btn_Click(object sender, RoutedEventArgs e)
        {
            ListView_Invertarization.ItemsSource=ConnectEntity.db.Inventory_History.ToList();
            HistoryStack.Visibility = Visibility.Visible;
            HistoryMovomentLogStack.Visibility = Visibility.Hidden;
            Maps.Visibility = Visibility.Hidden;
        }

        private void HistoryMovomentLog_Click(object sender, RoutedEventArgs e)
        {
            ListView_Invertarization.ItemsSource = ConnectEntity.db.HistoryMovomentLog.ToList();
            HistoryMovomentLogStack.Visibility = Visibility.Visible;
            HistoryStack.Visibility = Visibility.Hidden;
            Maps.Visibility = Visibility.Hidden;
        }

        private void HistoryMap_Btn_Click(object sender, RoutedEventArgs e)
        {
            Maps.Visibility = Visibility.Visible;
            HistoryStack.Visibility = Visibility.Hidden;
            HistoryMovomentLogStack.Visibility = Visibility.Hidden;

        }

        private void ClearMarkers()
        {
            Maps.Markers.Clear();

        }

        private void LoadMarkers()
        {



            ClearMarkers();

            string query = "Select Inventory_History.Name, HistoryMarker.History_Latitude, HistoryMarker.HistoryMarkerID, HistoryMarker.History_Longitude, Inventory_History.cabinet, Inventory_History.Image_invertarization from Inventory_History  join HistoryMarker  on Inventory_History.HistoryMarkerID=HistoryMarker.HistoryMarkerID";

            using (SqlConnection connection = new SqlConnection(MapsEntity.connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    double latitude = (double)row["History_Latitude"];
                    double longitude = (double)row["History_Longitude"];
                    string name = (string)row["Name"];
                    string cabinet = (string)row["cabinet"];
                    byte[] image = (byte[])row["Image_invertarization"];
                    


                    System.Windows.Controls.ToolTip toolTip = new System.Windows.Controls.ToolTip();
                    StackPanel stackPanelMainToolTip = new StackPanel();
                    StackPanel stackPanelImageToolTip = new StackPanel();
                    StackPanel stackPanelTextToolTip = new StackPanel();
                    stackPanelMainToolTip.Orientation = System.Windows.Controls.Orientation.Horizontal;
                    stackPanelImageToolTip.Orientation = System.Windows.Controls.Orientation.Horizontal;
                    stackPanelTextToolTip.Orientation = System.Windows.Controls.Orientation.Vertical;
                    stackPanelTextToolTip.VerticalAlignment = VerticalAlignment.Center;
                    stackPanelImageToolTip.Children.Add(new Image
                    {
                        Source = AddImage.ByteToArrayToImageInvertarization(image),
                        Height = 100,
                        Width = 100
                    });
                    stackPanelTextToolTip.Children.Add(new TextBlock { Text = name });
                    stackPanelTextToolTip.Children.Add(new TextBlock { Text = cabinet });
                    stackPanelMainToolTip.Children.Add(stackPanelImageToolTip);
                    stackPanelMainToolTip.Children.Add(stackPanelTextToolTip);
                    toolTip.Content = stackPanelMainToolTip;

                 





                    var marker = new GMapMarker(new PointLatLng(latitude, longitude))
                    {
                        Shape = new Image()
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

        private void Roll_up_Bt_Click(object sender, RoutedEventArgs e)
        {
            WindowsControls.Roll_Up_Mt(this);
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

        private void Deployment_Icon_Click(object sender, RoutedEventArgs e)
        {
            WindowsControls.DeploymentMT(this);
        }

        private void CloseDock_Btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Maps_Loaded(object sender, RoutedEventArgs e)
        {
            Maps.MinZoom = 5;
            Maps.MaxZoom = 30;
            Maps.Zoom = 15;
            Maps.MapProvider = GMapProviders.GoogleMap;
            Maps.DragButton = MouseButton.Left;
            Maps.Position = new PointLatLng(55.344181, 61.338637);
            GMapProvider.Language = LanguageType.Russian;
            LoadMarkers();
        }
    }
}
