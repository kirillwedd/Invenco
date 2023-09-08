using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invenco.JSONClass
{
   public class MyLocation
    { 
            public double Latitude { get; set; }
            public double Longitude { get; set; }    
        
    }

    public class MyLocationRequest
    {
        public string Action { get; set; } = "GetCurrentLocation";
    }
}
