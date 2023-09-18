using Invenco.ClassEntity;
using Invenco.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;


namespace Invenco.ClassInvertarization
{
    public static class AddEntityInvertarization
    {
        public static void AddInventoryStatus(System.Windows.Controls.TextBox textBox)
        {
          
            if(!string.IsNullOrWhiteSpace(textBox.Text))
            {
                ConnectEntity.db.InventoryStatus.Add(new InventoryStatus()
                {

                    IdStatusWritten =ConnectEntity.CountInventoryStatus,
                    StatusName= textBox.Text

                });
                ConnectEntity.db.SaveChanges();

            }
        }

        public static void AddCategory(System.Windows.Controls.TextBox textBox)
        {

            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                ConnectEntity.db.Category.Add(new Category()
                {

                    CategoryId = ConnectEntity.Category,
                    CategoryName = textBox.Text

                });
                ConnectEntity.db.SaveChanges();

            }
        }

        public static void Check(string MessageContext, string Messagecaption, MessageBoxImage boxImage, System.Windows.Controls.TextBox text,
                                 System.Windows.Controls.TextBox text1)
        {

           if(text.Text=="" && text1.Text=="")
            {
                MessageBox.Show(MessageContext, Messagecaption, (MessageBoxButton)boxImage);
            }
                  
                
            
        }



    }
}
