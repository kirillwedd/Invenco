//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Invenco.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inventory_History
    {
        public int History_InventoryID { get; set; }
        public int HistoryMarkerID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public System.DateTime StartDate { get; set; }
        public string cabinet { get; set; }
        public System.DateTime EndDate { get; set; }
        public string StatusName { get; set; }
        public byte[] Image_invertarization { get; set; }
        public Nullable<int> HistoryMovomentLogID { get; set; }
    
        public virtual HistoryMarker HistoryMarker { get; set; }
        public virtual HistoryMovomentLog HistoryMovomentLog { get; set; }
    }
}
