//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2014/09/28 - 16:22:53
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
    public partial class tblConsignorDTO
    {
        [DataMember()]
        public Int32 ConsignorId { get; set; }

        [DataMember()]
        [Required]
        public String ConsignorName { get; set; }

        [DataMember()]
        [Required]
        public string Code { get; set; }

        [DataMember()]
        [Required]
        public String Address { get; set; }

        [DataMember()]
        [Required]
        public String PhoneNo { get; set; }

        [DataMember()]
        [Required]
        public Nullable<int> Type { get; set; }

        [DataMember()]
        public String STNOCSTNO { get; set; }

        [DataMember()]
        public String TINNOVATNO { get; set; }

        [DataMember()]
        public String Description { get; set; }

        [DataMember()]
        public String PartyType { get; set; }

        [DataMember()]
        public String PartyNameWithCode { get; set; }

        [DataMember()]
        public Nullable<DateTime> CreationDate { get; set; }

        public List<SelectListItem> TypeList { get; set; }
    }
}
