using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using MaterialDesignThemes.Wpf;
using System.Windows.Controls.Primitives;
using System.Web.UI.WebControls.WebParts;
using Invenco.Entity;
using Invenco.ClassEntity;

namespace Invenco.ClassImage
{
   static class DeleteImage
    {

        private static Person_data _Data;

        public static ImageSource DeleteImages(Person_data person_Data, ImageBrush imageBrush)
        {
            person_Data.Image= ConnectEntity.person_Data.Image;

            _Data=person_Data;

            var chengePerson_Data = ConnectEntity.db.Person_data
                 .Where(x => x.PersonID == _Data.PersonID && x.Login == _Data.Login && x.Password == _Data.Password
                 && x.Name == _Data.Name && x.LastName == _Data.LastName && x.Patronymic == _Data.Patronymic
                 ).FirstOrDefault();


            chengePerson_Data.Image = null;
            ConnectEntity.db.SaveChanges();
            return imageBrush.ImageSource = AddImage.ByteToArrayToImage(person_Data.Image, person_Data);

        }
       
    }
}
