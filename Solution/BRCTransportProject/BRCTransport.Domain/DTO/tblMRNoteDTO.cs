//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2014-12-15 - 17:08:11
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Web.Mvc;

namespace BRCTransport.Domain
{
    [DataContract()]
    public partial class tblMRNoteDTO
    {
        [DataMember()]
        public Int32 MRId { get; set; }

        [DataMember()]
        [Required]
        public Nullable<Int32> MrNo { get; set; }

        [DataMember()]
        public int BillId { get; set; }

        [DataMember()]
        [Required]
        public Nullable<System.DateTime> MRDate { get; set; }

        [DataMember()]
        public String RecievedFrom { get; set; }

        [DataMember()]
        public String LocationFrom { get; set; }

        [DataMember()]
        public String LocationTo { get; set; }

        [Required]
        public Nullable<Int32> BillNo { get; set; }

        public String BillDate { get; set; }

        public Nullable<Double> BillAmount { get; set; }

        [DataMember()]
        public String NoofPackages { get; set; }

        [DataMember()]
        public String Weight { get; set; }

        [DataMember()]
        [Required]
        public Nullable<Double> AmountRecieved { get; set; }

        [DataMember()]
        [Required]
        public String WayOfRecieve { get; set; }

        [DataMember()]
        public Nullable<Double> Fright { get; set; }

        [DataMember()]
        public Nullable<Double> StCharges { get; set; }

        [DataMember()]
        public Nullable<Double> Hamali { get; set; }

        [DataMember()]
        public Nullable<Double> Other1 { get; set; }

        [DataMember()]
        public Nullable<Double> Other2 { get; set; }

        [DataMember()]
        public Nullable<Double> Other3 { get; set; }

        [DataMember()]
        public Nullable<Double> Other4 { get; set; }

        [DataMember()]
        [Required]
        public Nullable<Double> TotalAmount { get; set; }

        [DataMember()]
        public Nullable<DateTime> CreationDate { get; set; }

        public List<SelectListItem> PaymentType { get; set; }

        public Nullable<Int32> PartyId { get; set; }

        public String BranchCode { get; set; }

        public DateTime? PaymentDueDate { get; set; }

        public String CompanyName { get; set; }

        public int CompanyId { get; set; }
    }
}
