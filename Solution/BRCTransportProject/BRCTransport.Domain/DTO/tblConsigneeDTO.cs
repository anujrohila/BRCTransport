//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2014/09/28 - 16:22:50
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
    public partial class tblConsigneeDTO
    {
        [DataMember()]
        public Int32 ConsigneeId { get; set; }

        [DataMember()]
        [Required]
        public String ConsigneeName { get; set; }

        [DataMember()]
        [Required]
        public String Address { get; set; }

        [DataMember()]
        [Required]
        public String PhoneNo { get; set; }

        [DataMember()]
        public String STNOCSTNO { get; set; }

        [DataMember()]
        public String TINNOVATNO { get; set; }

        [DataMember()]
        public String Description { get; set; }

        [DataMember()]
        public Nullable<DateTime> CreationDate { get; set; }

        [DataMember()]
        public List<Int32> tblConsignmentNotes_ConsignmentNoteNo { get; set; }

    }
}
