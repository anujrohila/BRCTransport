//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2014-12-13 - 19:32:49
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BRCTransport.Domain
{
    [DataContract()]
    public partial class tblCashTransactionDTO
    {
        [DataMember()]
        public Int32 TransactionId { get; set; }

        [DataMember()]
        public Int32 AccountId { get; set; }

        [DataMember()]
        public DateTime TDate { get; set; }

        [DataMember()]
        public Double DrAmount { get; set; }

        [DataMember()]
        public Double CrAmount { get; set; }

        [DataMember()]
        public String Recievedby { get; set; }

        [DataMember()]
        public String PaidBy { get; set; }

        [DataMember()]
        public String Description { get; set; }

    }
}
