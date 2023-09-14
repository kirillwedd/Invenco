using Invenco.Entity;
using Invenco.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Invenco.ClassAvtrorization
{
    static class AvtrorizationCS 
    {
        public static bool EntityCheckAvtrorization(System.Windows.Controls.TextBox TextLogin, System.Windows.Controls.TextBox PasswordText, PasswordBox PasswordBox)
        {
            PETBASEEntities db = new PETBASEEntities();
            bool _sucess = true;
            if (db.Person_data.Any(x => x.Login == TextLogin.Text && PasswordText.Visibility==Visibility.Visible && x.Password == PasswordText.Text))
            {
                _sucess = true;
               
              
            }
            else if(db.Person_data.Any(x => x.Login == TextLogin.Text && PasswordBox.Visibility == Visibility.Visible && x.Password == PasswordBox.Password))
            {
                _sucess = true;
            }
            else
            {
                _sucess = false;
                MessageBox.Show("Пароль или логин введены неверно", "Ошибка");
            }
            return _sucess;


        }
    }
}
