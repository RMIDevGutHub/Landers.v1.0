//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Landers.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class ABTest
    {
        public decimal Id { get; set; }
        public string DescriptiveName { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> SiteId { get; set; }
        public int DeviceTypeId { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<bool> Enabled { get; set; }
    }
}
