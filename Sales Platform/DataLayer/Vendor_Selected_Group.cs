//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vendor_Selected_Group
    {
        public int VG_ID { get; set; }
        public int UserID { get; set; }
        public int GroupID { get; set; }
    
        public virtual User User { get; set; }
        public virtual Vendor_Groups Vendor_Groups { get; set; }
    }
}
