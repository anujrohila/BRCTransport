//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2014/09/28 - 16:22:46
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
    public partial class tblBillDTO
    {
        [DataMember()]
        public int BillId { get; set; }

        [DataMember()]
        [Required]
        [RegularExpression(@"^(|[1-9][0-9]*)$", ErrorMessage = "Bill no must be number.")]
        public int BillNo { get; set; }

        [DataMember()]
        [Required]
        public DateTime? BillDate { get; set; }

        public string BillDateString { get; set; }

        [DataMember()]
        [Required]
        public Nullable<Int32> PartyId { get; set; }

        [DataMember()]
        [Required]
        public String BranchCode { get; set; }

        [DataMember()]
        [Required]
        public DateTime? PaymentDueDate { get; set; }

        public string PaymentDueDateString { get; set; }

        [DataMember()]
        [Required]
        public String BillType { get; set; }

        [DataMember()]
        public String BasicOfChargesGC { get; set; }

        [DataMember()]
        public String Enclosure { get; set; }

        [DataMember()]
        [Required]
        public String ServiceTaxThrough { get; set; }

        [DataMember()]
        public String CheckedBy { get; set; }

        [DataMember()]
        public Nullable<int> GrandTotal { get; set; }

        [DataMember()]
        public String ServiceTaxRegdNo { get; set; }

        public double PendingAmount { get; set; }

        public tblConsignorDTO tblConsignorDTO { get; set; }

        public List<tblConsignorDTO> PartyList { get; set; }

        public List<SelectListItem> BillTypeList { get; set; }

        public List<SelectListItem> ServiceTaxThroughList { get; set; }

        public List<tblBillEntryDTO> BillEntryList { get; set; }

    }
}
