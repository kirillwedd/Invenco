using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Controls;
using Invenco.Entity;
namespace Invenco.ClassEntity
{
    static class ConnectEntity
    {
        public static PETBASEEntities db = new PETBASEEntities();

        private static int _count = db.Person_data.Count() + 1;

        private static int _countMarkers = db.Markers.Count() + 1;

        private static int _countMovLog=db.MovomentLog.Count() + 1;

        private static int _countInventoryStatus=db.InventoryStatus.Count() + 1;

        private static int _category=db.Category.Count() + 1;

        public static Person_data person_Data { get; set; }
        

        public static int CountPerson
        {
            get {return _count;}
            private set { _count = value;}
        }


        public static int CountMarkers
        {
            get { return _countMarkers;}
            private set { _countMarkers = value;}
        }

        public static int CountMovLog
        {
            get { return _countMovLog;}
            private set { _countMovLog = value;}
        }
        
        public static int CountInventoryStatus
        {
            get { return _countInventoryStatus;}
            private set { _countInventoryStatus = value;}
        }

        public static int Category
        {
            get { return _category;}
            private set { _category = value;}
        }

        public static void PersonData(System.Windows.Controls.TextBox TextLogin, System.Windows.Controls.TextBox PasswordText, PasswordBox PasswordBox )
        {
           Person_data person=(db.Person_data.Where(x=>x.Login==TextLogin.Text && (x.Password==PasswordText.Text || x.Password==PasswordBox.Password))).FirstOrDefault();

            person_Data = person;
        }

    }
}
