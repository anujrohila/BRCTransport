//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BRCTransport.Database.ORM
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblConsignor
    {
        public tblConsignor()
        {
            this.tblBills = new HashSet<tblBill>();
            this.tblConsignmentNotes = new HashSet<tblConsignmentNote>();
        }
    
        public int ConsignorId { get; set; }
        public string ConsignorName { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string STNOCSTNO { get; set; }
        public string TINNOVATNO { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<int> Type { get; set; }
        public string Code { get; set; }
    
        public virtual ICollection<tblBill> tblBills { get; set; }
        public virtual ICollection<tblConsignmentNote> tblConsignmentNotes { get; set; }
    }
}
