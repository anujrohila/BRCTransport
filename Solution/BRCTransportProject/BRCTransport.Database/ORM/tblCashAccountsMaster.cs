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
    
    public partial class tblCashAccountsMaster
    {
        public int AccountId { get; set; }
        public string AccountType { get; set; }
        public string OpeningBalance { get; set; }
        public Nullable<System.DateTime> OpeningDate { get; set; }
        public byte[] Description { get; set; }
    }
}