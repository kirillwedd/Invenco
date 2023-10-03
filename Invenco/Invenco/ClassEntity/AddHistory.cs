using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invenco.ClassEntity
{
    static class AddHistory
    {
        public static void AddInventoryHistory(int MarkersID)
        {
            ConnectEntity.invertarization = ConnectEntity.db.Invertarization.FirstOrDefault(x=>x.MarkersID==MarkersID);
        }
    }
}
