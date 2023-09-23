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
using System.Windows.Forms;
using System.Windows.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Invenco.ClassInvertarization
{
    public static class AddEntityInvertarization
    {
       

        public static int CheckCount { get; set; }


        private static StringBuilder _Builder;
        private static StringBuilder _Builder2;
        public static void AddInventoryStatus(System.Windows.Controls.TextBox textBox)
        {
            _Builder= new StringBuilder();
            if (!string.IsNullOrWhiteSpace(textBox.Text) && !ConnectEntity.db.InventoryStatus.Any(x=>x.StatusName.ToUpper().Contains(textBox.Text.ToUpper())))
            {
                ConnectEntity.db.InventoryStatus.Add(new InventoryStatus()
                {

                    IdStatusWritten = ConnectEntity.CountInventoryStatus,
                    StatusName = textBox.Text

                });
                ConnectEntity.db.SaveChanges();
                _Builder.AppendLine($"Вы добавили {textBox.Text} в базу");

            }
            


        }

        public static void AddCategory(System.Windows.Controls.TextBox textBox)
        {
            _Builder2= new StringBuilder();
            if (!string.IsNullOrWhiteSpace(textBox.Text) && !ConnectEntity.db.Category.Any(x => x.CategoryName.ToUpper().Contains(textBox.Text.ToUpper())))
            {
                ConnectEntity.db.Category.Add(new Category()
                {

                    CategoryId = ConnectEntity.Category,
                    CategoryName = textBox.Text,

                });
                ConnectEntity.db.SaveChanges();
                _Builder2.AppendLine($"Вы добавили {textBox.Text} в базу");

            }
            
        }

        public static void MessageBuilder()
        {
           
            string[] values = new string[] { _Builder.ToString(), _Builder2.ToString()};

            string buildstring = string.Join("", values);

            

            if (_Builder.Length>0 || _Builder2.Length>0)
            {
                System.Windows.MessageBox.Show(buildstring, "Данные");
            }
        }

        public static void MessageBugBuilder()
        {

            System.Windows.MessageBox.Show("Поля не заполнены", "Ошибка");
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

        public static int CountTextBoxesStackPanel(FrameworkElement parent)
        {
            int count = 0;

           
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);

                if (child is System.Windows.Controls.TextBox textBox && string.IsNullOrEmpty(textBox.Text))
                    count++;
                else if (child is FrameworkElement frameworkElement)
                    count += CountTextBoxesStackPanel(frameworkElement);
               
            }

            
            return count;

          
        }

        public static int CountTextBoxesExpander(FrameworkElement parent)
        {
            int count = 0;

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);

                if (child is System.Windows.Controls.TextBox )
                    count++;
                else if (child is FrameworkElement frameworkElement)
                    count += CountTextBoxesExpander(frameworkElement);
            }


            return count;


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

                      System.Windows.MessageBox.Show(Messagecontext, caption, MessageBoxButton.OK, messageBox);
                    }
                
            



           

        }


    }
}
