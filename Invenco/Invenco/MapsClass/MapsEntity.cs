﻿using GMap.NET;
using GMap.NET.WindowsPresentation;
using Invenco.ClassEntity;
using Invenco.ClassImage;
using Invenco.ClassTransmitted;
using Invenco.Entity;
using Invenco.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Effects;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;
using TextBox = System.Windows.Controls.TextBox;

namespace Invenco.MapsClass
{
    public static class MapsEntity
    {
   

        public static GMapMarker GMapMarker;

        public static GMapControl control;

        public static string connectionString = "Data Source=DESKTOP-HADQ0N5\\SQLSERVER;Initial Catalog=PETBASE;Integrated Security=True";
       
        public static void AddMarker(System.Windows.Controls.TextBox _nameTextBox, System.Windows.Controls.TextBox _textBoxInvertNumber,
                                     ComboBox _comboBoxCategory, System.Windows.Controls.TextBox _cabinet, ComboBox _comboBoxStatus,
                                     DatePicker _datePickerENdDate,System.Windows.Controls.Image image)
        {
           
                ConnectEntity.db.Markers.Add(new Markers()
                {
                    MarkerID = ConnectEntity.CountMarkers,
                    Latitude = Coordinates.X,
                    Longitude = Coordinates.Y,
                    Name = _nameTextBox.Text
                });


            
                ConnectEntity.db.Invertarization.Add(new Invertarization()
                {
                    InvertNumber = int.Parse(_textBoxInvertNumber.Text),
                    MarkersID = ConnectEntity.CountMarkers,
                    name = _nameTextBox.Text,
                    Category = _comboBoxCategory.Text,
                    StartDate = DateTime.Today,
                    cabinet = _cabinet.Text,
                    EndDate = _datePickerENdDate.SelectedDate,
                    WrittenOff=false,
                    StatusName = _comboBoxStatus.Text,
                    Image_Invertarization=AddImage.Photo




                });;
                ConnectEntity.db.SaveChanges();
            
          
        }

        public static void LoadedSource(ComboBox _comboBoxCategory, ComboBox _comboBoxStatus)
        {
            var Category=ConnectEntity.db.Category.ToList();
            _comboBoxCategory.ItemsSource = Category;

            var Status=ConnectEntity.db.InventoryStatus.ToList();
            _comboBoxStatus.ItemsSource = Status;

        }

        public static void BlokesDate(DatePicker datePicker)
        {
            DateTime today = DateTime.Today;
            
            CalendarDateRange dateRange = new CalendarDateRange(DateTime.MinValue,  today.AddDays(-1));

            datePicker.BlackoutDates.Add(dateRange);
        }

        public static void DeleteMarker(GMapControl gMapControl)
        {
            gMapControl.Markers.Remove(GMapMarker);
        }


    }
}
