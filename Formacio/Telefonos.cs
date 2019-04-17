//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Formacio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Telefonos
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string imageURL { get; set; }
        public string name { get; set; }
        public string snippet { get; set; }
        public string additionalFeatures { get; set; }
        public int idSo { get; set; }
        public string description { get; set; }
        public string storage_ram { get; set; }
        public string storage_flash { get; set; }
        public string size { get; set; }
        public string weight { get; set; }
        public Nullable<int> idConnectivity { get; set; }
        public string battery_standbyTime { get; set; }
        public string battery_talkTime { get; set; }
        public string battery_type { get; set; }
        public string camera_primary { get; set; }
        public string camera_features { get; set; }
        public string screenResolution { get; set; }
        public string screenSize { get; set; }
        public Nullable<bool> touchScreen { get; set; }
        public Nullable<int> idHardware { get; set; }
        public string availability { get; set; }
        public Nullable<int> idImages { get; set; }
    
        public virtual So So { get; set; }
        public virtual Connectivity Connectivity { get; set; }
        public virtual Hardware Hardware { get; set; }
        public virtual Images Images { get; set; }
    }
}
