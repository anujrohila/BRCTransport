//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2014/10/08 - 23:11:09
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
    public partial class tblConsignmentNoteDTO
    {
        [DataMember()]
        public Int32 ConsignmentId { get; set; }

        [DataMember()]
        [Required]
        public Nullable<int> ConsignmentNoteNo { get; set; }

        [DataMember()]
        [Required]
        public string CompanyName { get; set; }

        [DataMember()]
        public String PolicyNo { get; set; }

        [DataMember()]
        [Required]
        public DateTime? CompanyDate { get; set; }

        [DataMember()]
        public String CompanyPhone { get; set; }

        [DataMember()]
        public Nullable<double> CompanyAmount { get; set; }

        [DataMember()]
        [Required]
        public Nullable<int> ConsigneeId { get; set; }

        [DataMember()]
        [Required]
        public Nullable<int> ConsignorId { get; set; }

        [DataMember()]
        public String ConsigneeInvoiceNo { get; set; }

        [DataMember()]
        public String ConsigneeServiceTaxRegNo { get; set; }

        [DataMember()]
        public String ConsignorPurchaseOrderNo { get; set; }

        [DataMember()]
        public String ConsignorServiceTaxRegNo { get; set; }

        [DataMember()]
        [Required]
        public String FromCode { get; set; }

        [DataMember()]
        [Required]
        public String ToCode { get; set; }

        [DataMember()]
        public String NoofPackages { get; set; }

        [DataMember()]
        public String MethodOfPacking { get; set; }

        [DataMember()]
        public String ActualWtInKGS { get; set; }

        [DataMember()]
        public String CategoryOfLoad { get; set; }

        [DataMember()]
        public String Rate { get; set; }

        [DataMember()]
        public String LoadType { get; set; }

        [DataMember()]
        public String Distance { get; set; }

        [DataMember()]
        public String KMS { get; set; }

        [DataMember()]
        public String DescriptionSaidToContain { get; set; }

        [DataMember()]
        public String PrivateMarketOtherIdentificaion { get; set; }

        [DataMember()]
        public String BusinessType { get; set; }

        [DataMember()]
        public String AdvancedPaymentMRNo { get; set; }

        [DataMember()]
        public DateTime? AdvancedPaymentDate { get; set; }

        [DataMember()]
        public String AdvancedPaymentAmount { get; set; }

        [DataMember()]
        public String DimensionLength { get; set; }

        [DataMember()]
        public String DimensionWidth { get; set; }

        [DataMember()]
        public String DimensionHeight { get; set; }

        [DataMember()]
        public String DimensionNoOfPKGS { get; set; }

        [DataMember()]
        public String DimensionTotalCFTCMT { get; set; }

        [DataMember()]
        public String DimensionSinglePieceWeight { get; set; }

        [DataMember()]
        public String DeclarationNo { get; set; }

        [DataMember()]
        public String ValidUpto { get; set; }

        [DataMember()]
        public String DeclaredValueOfGoods { get; set; }

        [DataMember()]
        public String BasicOfBooking { get; set; }

        [DataMember()]
        public String BilledWithMs { get; set; }

        [DataMember()]
        public String BranchCode { get; set; }

        [DataMember()]
        public String ToPay { get; set; }

        [DataMember()]
        public String Rebooking { get; set; }

        [DataMember()]
        public String MainConsignmentNo { get; set; }

        [DataMember()]
        public String GoodRecievedDetails { get; set; }

        [DataMember()]
        [Required]
        public string Charges1 { get; set; }

        [DataMember()]
        [Required]
        public Nullable<double> Amount1 { get; set; }

        [DataMember()]
        public string Charges2 { get; set; }

        [DataMember()]
        public Nullable<double> Amount2 { get; set; }

        [DataMember()]
        public string Charges3 { get; set; }

        [DataMember()]
        public Nullable<double> Amount3 { get; set; }

        [DataMember()]
        public string Charges4 { get; set; }

        [DataMember()]
        public Nullable<double> Amount4 { get; set; }

        [DataMember()]
        public string Charges5 { get; set; }

        [DataMember()]
        public Nullable<double> Amount5 { get; set; }

        [DataMember()]
        public Nullable<double> FinalAmount { get; set; }

        [DataMember()]
        [Required]
        public string ServiceTaxisPayableBy { get; set; }

        [DataMember()]
        public String PanNo { get; set; }

        [DataMember()]
        public String PartyCode { get; set; }

        [DataMember()]
        public String ServicetaxThrough { get; set; }

        [DataMember()]
        public String ValidType { get; set; }

        [DataMember()]
        public String PhoneNo { get; set; }

        [DataMember()]
        public String AddressofIssuing { get; set; }

        [DataMember()]
        [Required]
        public DateTime? ConsignmentDate { get; set; }

        [DataMember()]
        public String CentralisedServiceTaxRegnNo { get; set; }

        public List<tblCompanyDTO> CompanyList { get; set; }

        public List<tblConsignorDTO> ConsigneeList { get; set; }

        public List<tblConsignorDTO> ConsignorList { get; set; }

        public List<SelectListItem> ServiceTaxisPayableByList { get; set; }
    }
}
