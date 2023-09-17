using Invenco.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Invenco.ClassEntity
{
    static class Message_Person_data_profile
    {
        private static Person_data _Data;
        public static void UploadingData(Person_data person_Data)
        {
            person_Data.PersonID = ConnectEntity.person_Data.PersonID;
            person_Data.Login = ConnectEntity.person_Data.Login;
            person_Data.Password = ConnectEntity.person_Data.Password;
            person_Data.Name = ConnectEntity.person_Data.Name;
            person_Data.LastName = ConnectEntity.person_Data.LastName;
            person_Data.Patronymic = ConnectEntity.person_Data.Patronymic;
            person_Data.Image = ConnectEntity.person_Data.Image;

            _Data= person_Data;
        }

        public static void AddPersonDataContext(string _messageText, string _caption, System.Windows.Controls.TextBox NameText,
                                              System.Windows.Controls.TextBox LastText, System.Windows.Controls.TextBox PatronymicText)
        {
            if(System.Windows.MessageBox.Show(_messageText, _caption, (MessageBoxButton)MessageBoxButtons.YesNo,
              (MessageBoxImage)MessageBoxIcon.Warning)==MessageBoxResult.Yes)
            {
                var chengePerson_Data = ConnectEntity.db.Person_data
                 .Where(x => x.PersonID == _Data.PersonID && x.Login == _Data.Login && x.Password == _Data.Password
                 && x.Name == _Data.Name && x.LastName == _Data.LastName && x.Patronymic == _Data.Patronymic
                 ).FirstOrDefault();

                chengePerson_Data.Name = NameText.Text;
                chengePerson_Data.LastName = LastText.Text;
                chengePerson_Data.Patronymic = PatronymicText.Text;
                ConnectEntity.db.SaveChanges();

                System.Windows.MessageBox.Show("Данные успешно внесены","Успех!");
            }
        }
    }
}
