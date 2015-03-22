using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRCTransport.Domain;
using BRCTransport.Database.ORM;

namespace BRCTransport.DAL
{
    public static class ConsignmentNoteRepository
    {
        #region [Deceleration]

        #endregion

        #region [Method]

        public static int Save(tblConsignmentNoteDTO tblConsignmentNoteDTO)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var tblConsignmentNoteObject = tblConsignmentNoteDTO.ToEntity();
                if (tblConsignmentNoteDTO.ConsignmentId == 0)
                {
                    dbObject.tblConsignmentNotes.Add(tblConsignmentNoteObject);
                }
                else
                {
                    tblConsignmentNoteObject = dbObject.tblConsignmentNotes.Find(tblConsignmentNoteDTO.ConsignmentId);
                    tblConsignmentNoteObject.ConsignmentNoteNo = tblConsignmentNoteDTO.ConsignmentNoteNo;
                    tblConsignmentNoteObject.CompanyName = tblConsignmentNoteDTO.CompanyName;
                    tblConsignmentNoteObject.PolicyNo = tblConsignmentNoteDTO.PolicyNo;
                    tblConsignmentNoteObject.CompanyDate = tblConsignmentNoteDTO.CompanyDate;
                    tblConsignmentNoteObject.CompanyAmount = tblConsignmentNoteDTO.CompanyAmount;
                    tblConsignmentNoteObject.CompanyPhone = tblConsignmentNoteDTO.CompanyPhone;
                    tblConsignmentNoteObject.ConsigneeId = tblConsignmentNoteDTO.ConsigneeId;
                    tblConsignmentNoteObject.ConsignorId = tblConsignmentNoteDTO.ConsignorId;
                    tblConsignmentNoteObject.ConsigneeInvoiceNo = tblConsignmentNoteDTO.ConsigneeInvoiceNo;
                    tblConsignmentNoteObject.ConsigneeServiceTaxRegNo = tblConsignmentNoteDTO.ConsigneeServiceTaxRegNo;
                    tblConsignmentNoteObject.ConsignorPurchaseOrderNo = tblConsignmentNoteDTO.ConsignorPurchaseOrderNo;
                    tblConsignmentNoteObject.ConsignorServiceTaxRegNo = tblConsignmentNoteDTO.ConsignorServiceTaxRegNo;
                    tblConsignmentNoteObject.FromCode = tblConsignmentNoteDTO.FromCode;
                    tblConsignmentNoteObject.ToCode = tblConsignmentNoteDTO.ToCode;
                    tblConsignmentNoteObject.NoofPackages = tblConsignmentNoteDTO.NoofPackages;
                    tblConsignmentNoteObject.MethodOfPacking = tblConsignmentNoteDTO.MethodOfPacking;
                    tblConsignmentNoteObject.ActualWtInKGS = tblConsignmentNoteDTO.ActualWtInKGS;
                    tblConsignmentNoteObject.CategoryOfLoad = tblConsignmentNoteDTO.CategoryOfLoad;
                    tblConsignmentNoteObject.Rate = tblConsignmentNoteDTO.Rate;
                    tblConsignmentNoteObject.LoadType = tblConsignmentNoteDTO.LoadType;
                    tblConsignmentNoteObject.Distance = tblConsignmentNoteDTO.Distance;
                    tblConsignmentNoteObject.KMS = tblConsignmentNoteDTO.KMS;
                    tblConsignmentNoteObject.DescriptionSaidToContain = tblConsignmentNoteDTO.DescriptionSaidToContain;
                    tblConsignmentNoteObject.PrivateMarketOtherIdentificaion = tblConsignmentNoteDTO.PrivateMarketOtherIdentificaion;
                    tblConsignmentNoteObject.BusinessType = tblConsignmentNoteDTO.BusinessType;
                    tblConsignmentNoteObject.AdvancedPaymentMRNo = tblConsignmentNoteDTO.AdvancedPaymentMRNo;
                    tblConsignmentNoteObject.AdvancedPaymentDate = tblConsignmentNoteDTO.AdvancedPaymentDate;
                    tblConsignmentNoteObject.AdvancedPaymentAmount = tblConsignmentNoteDTO.AdvancedPaymentAmount;
                    tblConsignmentNoteObject.DimensionLength = tblConsignmentNoteDTO.DimensionLength;
                    tblConsignmentNoteObject.DimensionWidth = tblConsignmentNoteDTO.DimensionWidth;
                    tblConsignmentNoteObject.DimensionHeight = tblConsignmentNoteDTO.DimensionHeight;
                    tblConsignmentNoteObject.DimensionNoOfPKGS = tblConsignmentNoteDTO.DimensionNoOfPKGS;
                    tblConsignmentNoteObject.DimensionTotalCFTCMT = tblConsignmentNoteDTO.DimensionTotalCFTCMT;
                    tblConsignmentNoteObject.DimensionSinglePieceWeight = tblConsignmentNoteDTO.DimensionSinglePieceWeight;
                    tblConsignmentNoteObject.DeclarationNo = tblConsignmentNoteDTO.DeclarationNo;
                    tblConsignmentNoteObject.ValidUpto = tblConsignmentNoteDTO.ValidUpto;
                    tblConsignmentNoteObject.DeclaredValueOfGoods = tblConsignmentNoteDTO.DeclaredValueOfGoods;
                    tblConsignmentNoteObject.BasicOfBooking = tblConsignmentNoteDTO.BasicOfBooking;
                    tblConsignmentNoteObject.BilledWithMs = tblConsignmentNoteDTO.BilledWithMs;
                    tblConsignmentNoteObject.BranchCode = tblConsignmentNoteDTO.BranchCode;
                    tblConsignmentNoteObject.ToPay = tblConsignmentNoteDTO.ToPay;
                    tblConsignmentNoteObject.Rebooking = tblConsignmentNoteDTO.Rebooking;
                    tblConsignmentNoteObject.MainConsignmentNo = tblConsignmentNoteDTO.MainConsignmentNo;
                    tblConsignmentNoteObject.GoodRecievedDetails = tblConsignmentNoteDTO.GoodRecievedDetails;
                    tblConsignmentNoteObject.Charges1 = tblConsignmentNoteDTO.Charges1;
                    tblConsignmentNoteObject.Amount1 = tblConsignmentNoteDTO.Amount1;
                    tblConsignmentNoteObject.Charges2 = tblConsignmentNoteDTO.Charges2;
                    tblConsignmentNoteObject.Amount2 = tblConsignmentNoteDTO.Amount2;
                    tblConsignmentNoteObject.Charges3 = tblConsignmentNoteDTO.Charges3;
                    tblConsignmentNoteObject.Amount3 = tblConsignmentNoteDTO.Amount3;
                    tblConsignmentNoteObject.Charges4 = tblConsignmentNoteDTO.Charges4;
                    tblConsignmentNoteObject.Amount4 = tblConsignmentNoteDTO.Amount4;
                    tblConsignmentNoteObject.Charges5 = tblConsignmentNoteDTO.Charges5;
                    tblConsignmentNoteObject.Amount5 = tblConsignmentNoteDTO.Amount5;
                    tblConsignmentNoteObject.FinalAmount = tblConsignmentNoteDTO.FinalAmount;
                    tblConsignmentNoteObject.ServiceTaxisPayableBy = tblConsignmentNoteDTO.ServiceTaxisPayableBy;
                    tblConsignmentNoteObject.FinalAmount = tblConsignmentNoteDTO.FinalAmount;
                    tblConsignmentNoteObject.PanNo = tblConsignmentNoteDTO.PanNo;
                    tblConsignmentNoteObject.PartyCode = tblConsignmentNoteDTO.PartyCode;
                    tblConsignmentNoteObject.ServicetaxThrough = tblConsignmentNoteDTO.ServicetaxThrough;
                    tblConsignmentNoteObject.ValidType = tblConsignmentNoteDTO.ValidType;
                    tblConsignmentNoteObject.PhoneNo = tblConsignmentNoteDTO.PhoneNo;
                    tblConsignmentNoteObject.AddressofIssuing = tblConsignmentNoteDTO.AddressofIssuing;
                    tblConsignmentNoteObject.ConsignmentDate = tblConsignmentNoteDTO.ConsignmentDate;
                    tblConsignmentNoteObject.CentralisedServiceTaxRegnNo = tblConsignmentNoteDTO.CentralisedServiceTaxRegnNo;
                }
                dbObject.SaveChanges();
                return tblConsignmentNoteObject.ConsignmentId;
            }
        }

        public static bool CheckDuplicateConsignmentNoteNo(int ConsignmentId, int ConsignmentNoteNo)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var ConsignmentNoteList = dbObject.tblConsignmentNotes.Where(s => s.ConsignmentNoteNo == ConsignmentNoteNo && s.ConsignmentId != ConsignmentId).ToList();
                if (ConsignmentNoteList.Count() > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static int GetConsignmentNoteNo()
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                if (dbObject.tblConsignmentNotes.Count() > 0)
                {
                    return dbObject.tblConsignmentNotes.Max(ConsignmentNote => ConsignmentNote.ConsignmentNoteNo ?? 0);
                }
                else
                {
                    return 0;
                }
            }
        }

        public static tblConsignmentNoteDTO Get(int ConsignmentNoteId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                return dbObject.tblConsignmentNotes.Find(ConsignmentNoteId).ToDTO();
            }
        }

        public static List<tblConsignmentNoteDTO> GetAll()
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                return dbObject.tblConsignmentNotes.ToList().ToDTOs();
            }
        }

        public static bool Delete(int ConsignmentId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var tblConsignmentNote = dbObject.tblConsignmentNotes.Find(ConsignmentId);
                dbObject.tblConsignmentNotes.Remove(tblConsignmentNote);
                var ConsignmentNoteEntrys = dbObject.tblConsignmentNotes.Where(be => be.ConsignmentId == ConsignmentId);
                foreach (var ConsignmentNoteEntry in ConsignmentNoteEntrys)
                {
                    dbObject.tblConsignmentNotes.Remove(ConsignmentNoteEntry);
                }
                dbObject.SaveChanges();
                return true;
            }
        }

        #endregion
    }
}
