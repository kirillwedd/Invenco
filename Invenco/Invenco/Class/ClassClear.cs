using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Invenco.Class
{
    static class ClassClear
    {
        public static void ClearsTextBox(Grid grid)
        {
          
                foreach (var element in grid.Children)
                {
                    if (element is StackPanel stackPanel)
                    {
                        foreach (var stackElement in stackPanel.Children)
                        {
                            if (stackElement is TextBox textBox)
                            {
                                textBox.Clear();
                            }
                        }
                    }
                }
        }

        public static void ClearsPasswordBox(Grid grid)
        {
            foreach (var element in grid.Children)
            {
                if (element is StackPanel stackPanel)
                {
                    foreach (var stackElement in stackPanel.Children)
                    {
                        if (stackElement is PasswordBox passwordBox)
                        {
                            passwordBox.Clear();
                        }
                    }
                }

            }
        }

        public static void Clears(TextBox textBox)
        {
            bool word;
            string[] Words = "Фамилия Имя Отчество".Split(' ');

            foreach(var textForbidden in textBox.Text.Split(' '))
            {
                word=Words.Contains(textForbidden);

                if (word == true)
                    textBox.Clear();
                    
            }
           
        }

        public static void Completion(TextBox textBox, string word)
        {
            if(textBox.Text=="")
            {
                textBox.Text = word;
            }
        }
    }
}
