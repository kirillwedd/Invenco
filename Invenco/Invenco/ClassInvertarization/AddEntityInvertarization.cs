using Invenco.ClassEntity;
using Invenco.Entity;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Invenco.ClassInvertarization
{
    public static class AddEntityInvertarization
    {
        private static StringBuilder _Builder;
        private static StringBuilder _Builder2;
        public static void AddInventoryStatus(System.Windows.Controls.TextBox textBox)
        {
            _Builder= new StringBuilder();
            if (!string.IsNullOrWhiteSpace(textBox.Text) || ConnectEntity.db.InventoryStatus.Any(x=>x.StatusName==textBox.Text.ToUpper()))
            {
                ConnectEntity.db.InventoryStatus.Add(new InventoryStatus()
                {

                    IdStatusWritten = ConnectEntity.CountInventoryStatus,
                    StatusName = textBox.Text

                });
                ConnectEntity.db.SaveChanges();

            }
            else
            {
                _Builder.AppendLine("Поле 'Статус' не заполнено или уже есть в базе");
            }


        }

        public static void AddCategory(System.Windows.Controls.TextBox textBox)
        {
            _Builder2= new StringBuilder();
            if (!string.IsNullOrWhiteSpace(textBox.Text) || ConnectEntity.db.Category.Any(x => x.CategoryName == textBox.Text.ToUpper()))
            {
                ConnectEntity.db.Category.Add(new Category()
                {

                    CategoryId = ConnectEntity.Category,
                    CategoryName = textBox.Text

                });
                ConnectEntity.db.SaveChanges();

            }
            else
            {
                _Builder2.AppendLine("Поле 'Категория' не заполнено или уже есть в базе");
            }
        }

        public static void MessageBuilder()
        {
            string s= _Builder.ToString();
            string ss = _Builder2.ToString();
            string[] values = new string[] { s, ss};

            string buildstring = string.Join("", values);

            if (_Builder.Length>0 || _Builder2.Length>0)
            {
                MessageBox.Show(buildstring);
            }
        }


        public static System.Windows.Controls.TextBox FindTextBoxInExpander(Expander expander)
        {
            var stackPanels = expander.FindChildren<StackPanel>();

            foreach (var stackPanel in stackPanels)
            {
                var textBox = stackPanel.FindChildren<System.Windows.Controls.TextBox>().FirstOrDefault();
                if (textBox != null)
                {
                    return textBox;
                }

                var childExpanders = stackPanel.FindChildren<Expander>();
                foreach (var childExpander in childExpanders)
                {
                    var nestedTextBox = FindTextBoxInExpander(childExpander);
                    if (nestedTextBox != null)
                    {
                        return nestedTextBox;
                    }
                }
            }

            return null;


        }

        public static IEnumerable<T> FindChildren<T>(this DependencyObject parent) where T : DependencyObject
        {
            if (parent != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(parent, i);

                    if (child is T foundElement)
                    {
                        yield return foundElement;
                    }

                    foreach (var descendant in FindChildren<T>(child))
                    {
                        yield return descendant;
                    }
                }
            }
        }

        public static void CheckExpanderForTextBox(Expander expander, string Messagecontext, string caption, MessageBoxImage messageBox)
        {
            System.Windows.Controls.TextBox textBox = FindTextBoxInExpander(expander);

         
           
                    if(textBox.Text=="")
                    {
                        
                        MessageBox.Show(Messagecontext, caption, MessageBoxButton.OK, messageBox);
                    }
                
            



           

        }


    }
}
