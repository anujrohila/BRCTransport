//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2014-12-14 - 15:56:55
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace BRCTransport.Domain
{
    [DataContract()]
    public partial class tblAccountsMasterDTO
    {
        [DataMember()]
        public Int32 AccountId { get; set; }

        [DataMember()]
        [Required]
        public String AccountName { get; set; }

        [DataMember()]
        [Required]
        public String AccountType { get; set; }

        [DataMember()]
        public String AccountTypeName { get; set; }

        [DataMember()]
        public Nullable<Int32> AccountNo { get; set; }

        [DataMember()]
        public String Addrees { get; set; }

        [DataMember()]
        public String PhoneNo { get; set; }

        [DataMember()]
        [Required]
        public Nullable<Double> OpeningBalance { get; set; }

        [DataMember()]
        [Required]
        public Nullable<DateTime> OpeningDate { get; set; }

        [DataMember()]
        public Byte[] Description { get; set; }
    }
}