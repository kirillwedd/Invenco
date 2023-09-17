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
using Invenco.ClassImage;
using Invenco.Entity;

namespace Invenco.View
{
    /// <summary>
    /// Логика взаимодействия для Person_data_profile.xaml
    /// </summary>
    public partial class Person_data_profile : Window
    {
        public Person_data_profile(Person_data person_Data)
        {
            InitializeComponent();
            PhotoEllipse.ImageSource= AddImage.ByteToArrayToImage(person_Data.Image, person_Data);
            Message_Person_data_profile.UploadingData(person_Data);
        }

        private void Name_TB_MouseEnter(object sender, MouseEventArgs e)
        {
            ClassClear.Clears(Name_TB);
        }

        private void Name_TB_MouseLeave(object sender, MouseEventArgs e)
        {
            ClassClear.Completion(Name_TB, "Имя");
        }

        private void LastName_TB_MouseEnter(object sender, MouseEventArgs e)
        {
            ClassClear.Clears(LastName_TB);
        }

        private void LastName_TB_MouseLeave(object sender, MouseEventArgs e)
        {
            ClassClear.Completion(LastName_TB, "Фамилия");
        }

        private void Patronymic_TB_MouseEnter(object sender, MouseEventArgs e)
        {
            ClassClear.Clears(Patronymic_TB);
        }

        private void Patronymic_TB_MouseLeave(object sender, MouseEventArgs e)
        {
            ClassClear.Completion(Patronymic_TB, "Отчество");
        }

        private void AddPersonFullData_Bt_Click(object sender, RoutedEventArgs e)
        {
            Message_Person_data_profile.AddPersonDataContext("Внимание! Проверьте правильность введенных данных","", Name_TB, LastName_TB, Patronymic_TB);
        }
    }
}
