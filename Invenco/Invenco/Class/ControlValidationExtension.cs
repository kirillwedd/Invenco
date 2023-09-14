using Invenco.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Invenco.Entity;


namespace Invenco.Class
{
    static class ControlValidationExtension
    {
        public static Validator Rules(this System.Windows.Controls.TextBox control) => new Validator(control, control.Text);

        public static Validator Rules(this PasswordBox control) => new Validator(control, control.Password);
    }

    class Validator : Window
    {
        private readonly Control _control;
        private readonly string _content;
        private char[] SpecChar = new char[] { '*', '&', '{', '}', '|', '+' };
        private bool _sucess = true;

        private int checksc = 0;

        public int Checksc
        {
            get { return checksc; }
            private set { checksc = value; }
        }

        private int checknum;

        public int CheckNum
        {
            get { return checknum; }
            private set { checknum = value; }
        }

        private int repeat;

        public int Repeat
        {
            get { return repeat; }
            private set { repeat = value; }
        }

        private char countchar;

        public char CountChar
        {
            get { return countchar; }
            private set { countchar = value; }
        }







        public Validator(Control control, string content)
            => (_control, _content) = (control, content);

        public Validator MinCharacters(int count)
        {
            if (_content.Length < count)
            {
                _sucess = false;
              
            }
           
            
            return this;
        }

        public Validator SpecCharacters(int count)
        {  
          
            
            foreach (char c in _content  )
            {

                foreach (char sc in SpecChar)
                {
                    if (sc == c)
                        Checksc++;
                    
                    
                   
                }
              
                
            }
                if (Checksc < count )
                {
                    _sucess = false;

                }

            return this;
        }

        public Validator  Repeator(int count)
        {
            foreach (char c in _content)
            {

                if (CountChar == c)
                    Repeat++;
                CountChar= c;

            }

            if(Repeat>count)
            {
                _sucess= false;
            }
            return this;
        }

        public Validator CountNumbers(int count)
        {
            foreach (char c in _content)
            {
                if (Char.IsDigit(c))
                    CheckNum++;
            }

            if (CheckNum < count)
            {
                _sucess = false;

            }
            return this;
        }

        public Validator SpecCharactersPasBox(int count)
        {

          
            foreach (char c in _content)
            {

                foreach (char sc in SpecChar)
                {
                    if (sc == c)
                        Checksc++;



                }


            }
            if (Checksc < count)
            {
                _sucess = false;

            }
            
            return this;
        }

        public Validator IsEmail(System.Windows.Controls.TextBox textBox)
        {
           
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            if (regex.IsMatch(textBox.Text) == false)
            _sucess= false;
            return this;
           
         
            
        }

        public Validator  EntityCheckLogin(System.Windows.Controls.TextBox textBox)
        { 
          PETBASEEntities db = new PETBASEEntities();

            if (db.Person_data.Any(x => x.Login == textBox.Text))
            {
                _sucess= false;
            }
            
            return this;
        }

       


        public  bool Validate()
        {
            if(_sucess==false)
            {
                _control.ToolTip = "Это поле введено некоректно";
                _control.Background = Brushes.Red;
            }
            else
            {
                _control.ToolTip = null;              
            }
           return _sucess;

           
        }
        
        
        
    }
    
}
