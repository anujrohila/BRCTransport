using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRCTransport.Domain;
using BRCTransport.Database.ORM;

namespace BRCTransport.DAL
{
    public static class MRNoteRepository
    {
        #region [Deceleration]

        #endregion

        #region [Method]

        public static int Save(tblMRNoteDTO tblMRNoteDTO)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var tblMRNote = tblMRNoteDTO.ToEntity();
                if (tblMRNoteDTO.MRId == 0)
                {
                    dbObject.tblMRNotes.Add(tblMRNote);
                }
                else
                {
                    tblMRNote = dbObject.tblMRNotes.Find(tblMRNoteDTO.MRId);
                    tblMRNote.MrNo = tblMRNoteDTO.MrNo;
                    tblMRNote.BillId = tblMRNoteDTO.BillId;
                    tblMRNote.MRDate = tblMRNoteDTO.MRDate;
                    tblMRNote.RecievedFrom = tblMRNoteDTO.RecievedFrom;
                    tblMRNote.LocationFrom = tblMRNoteDTO.LocationFrom;
                    tblMRNote.LocationTo = tblMRNoteDTO.LocationTo;
                    tblMRNote.NoofPackages = tblMRNoteDTO.NoofPackages;
                    tblMRNote.Weight = tblMRNoteDTO.Weight;
                    tblMRNote.AmountRecieved = tblMRNoteDTO.AmountRecieved;
                    tblMRNote.WayOfRecieve = tblMRNoteDTO.WayOfRecieve;
                    tblMRNote.Fright = tblMRNoteDTO.Fright;
                    tblMRNote.StCharges = tblMRNoteDTO.StCharges;
                    tblMRNote.Hamali = tblMRNoteDTO.Hamali;
                    tblMRNote.Other1 = tblMRNoteDTO.Other1;
                    tblMRNote.Other2 = tblMRNoteDTO.Other2;
                    tblMRNote.Other3 = tblMRNoteDTO.Other3;
                    tblMRNote.Other4 = tblMRNoteDTO.Other4;
                    tblMRNote.TotalAmount = tblMRNoteDTO.TotalAmount;
                }
                dbObject.SaveChanges();
                return tblMRNote.MRId;
            }
        }

        public static bool CheckDuplicateMRNo(int mrId, int mrNo)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var billList = dbObject.tblMRNotes.Where(s => s.MrNo == mrNo && s.MRId != mrId).ToList();
                if (billList.Count() > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static int GetMRNo()
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                if (dbObject.tblMRNotes.Count() > 0)
                {
                    return dbObject.tblMRNotes.Max(mrNote => mrNote.MrNo ?? 0);
                }
                else
                {
                    return 0;
                }
            }
        }

        public static tblMRNoteDTO Get(int mrId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                return dbObject.tblMRNotes.Find(mrId).ToDTO();
            }
        }

        public static List<tblMRNoteDTO> GetAll()
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                return dbObject.tblMRNotes.ToList().ToDTOs();
            }
        }

        public static bool Delete(int mrId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var tblMRNote = dbObject.tblMRNotes.Find(mrId);
                dbObject.tblMRNotes.Remove(tblMRNote);
                dbObject.SaveChanges();
                return true;
            }
        }

        public static tblBillDTO GetMRNoteBillDetail(int billNo)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {

                var billInfo = dbObject.tblBills.Where(bill => bill.BillNo == billNo).FirstOrDefault();
                if (billInfo != null)
                {
                    var billId = billInfo.BillId;
                    if (billId > 0)
                    {
                        var tblBillDetails = dbObject.tblBills.Where(bill => bill.BillNo == billNo).FirstOrDefault().ToDTO();
                        if (tblBillDetails != null)
                        {
                            var amountRecieved = dbObject.tblMRNotes.Where(mrNote => mrNote.BillId == billId).Sum(mrNote => mrNote.AmountRecieved);
                            tblBillDetails.BillDateString = tblBillDetails.BillDate.Value.ToString("dd-MM-yyyy");
                            if (amountRecieved != null)
                            {
                                tblBillDetails.PendingAmount = (tblBillDetails.GrandTotal - amountRecieved) ?? 0;
                            }
                            else
                            {
                                tblBillDetails.PendingAmount = tblBillDetails.GrandTotal ?? 0;
                            }
                        }
                        return tblBillDetails;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public static List<tblMRNoteDTO> GetBillMRNote(int billId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                return dbObject.tblMRNotes.Where(mrNOte => mrNOte.BillId == billId).ToList().ToDTOs();

            }
        }

        #endregion



        #region LRNoteRepository
       
        #region [Deceleration]

        #endregion

        #region Method

        public static int Save(tblConsignmentNoteDTO tblConsignmentNoteDTO)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var tblLRnote = tblConsignmentNoteDTO.ToEntity();
                if (tblConsignmentNoteDTO.ConsignmentId == 0)
                {
                    dbObject.tblConsignmentNotes.Add(tblLRnote);
                }
                else
                {
                    tblLRnote = dbObject.tblConsignmentNotes.Find(tblConsignmentNoteDTO.ConsignmentId);
                    tblLRnote.ConsignmentNoteNo = tblConsignmentNoteDTO.ConsignmentNoteNo;
                    tblLRnote.CompanyName = tblConsignmentNoteDTO.CompanyName;
                    tblLRnote.PolicyNo = tblConsignmentNoteDTO.PolicyNo;
                    tblLRnote.CompanyDate = tblConsignmentNoteDTO.CompanyDate;
                    tblLRnote.CompanyAmount = tblConsignmentNoteDTO.CompanyAmount;
                    tblLRnote.ConsigneeId = tblConsignmentNoteDTO.ConsigneeId;
                    tblLRnote.NoofPackages = tblConsignmentNoteDTO.NoofPackages;
                    tblLRnote.ConsignorId = tblConsignmentNoteDTO.ConsignorId;
                    tblLRnote.ConsigneeInvoiceNo = tblConsignmentNoteDTO.ConsigneeInvoiceNo;
                    tblLRnote.ConsigneeServiceTaxRegNo = tblConsignmentNoteDTO.ConsigneeServiceTaxRegNo;
                    tblLRnote.ConsignorPurchaseOrderNo = tblConsignmentNoteDTO.ConsignorPurchaseOrderNo;
                    tblLRnote.ConsignorServiceTaxRegNo = tblConsignmentNoteDTO.ConsignorServiceTaxRegNo;
                    tblLRnote.FromCode = tblConsignmentNoteDTO.FromCode;
                    tblLRnote.ToCode = tblConsignmentNoteDTO.ToCode;
                    tblLRnote.NoofPackages = tblConsignmentNoteDTO.NoofPackages;
                    tblLRnote.MethodOfPacking = tblConsignmentNoteDTO.MethodOfPacking;
                    tblLRnote.ActualWtInKGS = tblConsignmentNoteDTO.ActualWtInKGS;
                    tblLRnote.CategoryOfLoad = tblConsignmentNoteDTO.CategoryOfLoad;

                    tblLRnote.Rate = tblConsignmentNoteDTO.Rate;
                    tblLRnote.LoadType = tblConsignmentNoteDTO.LoadType;
                    tblLRnote.Distance = tblConsignmentNoteDTO.Distance;
                    tblLRnote.KMS = tblConsignmentNoteDTO.KMS;
                    tblLRnote.DescriptionSaidToContain = tblConsignmentNoteDTO.DescriptionSaidToContain;
                    tblLRnote.PrivateMarketOtherIdentificaion = tblConsignmentNoteDTO.PrivateMarketOtherIdentificaion;
                    tblLRnote.BusinessType = tblConsignmentNoteDTO.BusinessType;
                    tblLRnote.AdvancedPaymentMRNo = tblConsignmentNoteDTO.AdvancedPaymentMRNo;
                    tblLRnote.AdvancedPaymentDate = tblConsignmentNoteDTO.AdvancedPaymentDate;
                    tblLRnote.AdvancedPaymentAmount = tblConsignmentNoteDTO.AdvancedPaymentAmount;
                    tblLRnote.DimensionLength = tblConsignmentNoteDTO.DimensionLength;
                    tblLRnote.DimensionWidth = tblConsignmentNoteDTO.DimensionWidth;
                    tblLRnote.DimensionHeight = tblConsignmentNoteDTO.DimensionHeight;
                    tblLRnote.DimensionNoOfPKGS = tblConsignmentNoteDTO.DimensionNoOfPKGS;
                    tblLRnote.DimensionTotalCFTCMT = tblConsignmentNoteDTO.DimensionTotalCFTCMT;
                    tblLRnote.DimensionSinglePieceWeight = tblConsignmentNoteDTO.DimensionSinglePieceWeight;
                    tblLRnote.DeclarationNo = tblConsignmentNoteDTO.DeclarationNo;
                    tblLRnote.ValidUpto = tblConsignmentNoteDTO.ValidUpto;
                    tblLRnote.DeclaredValueOfGoods = tblConsignmentNoteDTO.DeclaredValueOfGoods;
                    tblLRnote.BasicOfBooking = tblConsignmentNoteDTO.BasicOfBooking;
                    tblLRnote.BilledWithMs = tblConsignmentNoteDTO.BilledWithMs;
                    tblLRnote.BranchCode = tblConsignmentNoteDTO.BranchCode;
                    tblLRnote.ToPay = tblConsignmentNoteDTO.ToPay;
                    tblLRnote.Rebooking = tblConsignmentNoteDTO.Rebooking;
                    tblLRnote.MainConsignmentNo = tblConsignmentNoteDTO.MainConsignmentNo;
                    tblLRnote.GoodRecievedDetails = tblConsignmentNoteDTO.GoodRecievedDetails;
                    tblLRnote.PanNo = tblConsignmentNoteDTO.PanNo;
                    tblLRnote.PartyCode = tblConsignmentNoteDTO.PartyCode;
                    tblLRnote.ServicetaxThrough = tblConsignmentNoteDTO.ServicetaxThrough;
                    tblLRnote.ValidType = tblConsignmentNoteDTO.ValidType;
                    tblLRnote.PhoneNo = tblConsignmentNoteDTO.PhoneNo;
                    tblLRnote.AddressofIssuing = tblConsignmentNoteDTO.AddressofIssuing;
                    tblLRnote.ConsignmentDate = tblConsignmentNoteDTO.ConsignmentDate;
                    tblLRnote.CentralisedServiceTaxRegnNo = tblConsignmentNoteDTO.CentralisedServiceTaxRegnNo;
                    tblLRnote.CompanyPhone = tblConsignmentNoteDTO.CompanyPhone;
                    tblLRnote.Charges1 = tblConsignmentNoteDTO.Charges1;
                    tblLRnote.Amount1 = tblConsignmentNoteDTO.Amount1;
                    tblLRnote.Charges2 = tblConsignmentNoteDTO.Charges2;
                    tblLRnote.Amount2 = tblConsignmentNoteDTO.Amount2;
                    tblLRnote.Charges3 = tblConsignmentNoteDTO.Charges3;
                    tblLRnote.Amount3 = tblConsignmentNoteDTO.Amount3;
                    tblLRnote.Charges4 = tblConsignmentNoteDTO.Charges4;
                    tblLRnote.Amount4 = tblConsignmentNoteDTO.Amount4;
                    tblLRnote.Charges5 = tblConsignmentNoteDTO.Charges5;
                    tblLRnote.Amount5 = tblConsignmentNoteDTO.Amount5;
                    tblLRnote.FinalAmount = tblConsignmentNoteDTO.FinalAmount;
                    tblLRnote.ServiceTaxisPayableBy = tblConsignmentNoteDTO.ServiceTaxisPayableBy;
                 
                }
                dbObject.SaveChanges();
                return tblLRnote.ConsignmentId;
            }
        }

        public static bool CheckDuplicateLRNo(int lrId, int lrNo)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var billList = dbObject.tblConsignmentNotes.Where(s => s.ConsignmentId != lrId && s.ConsignmentNoteNo == lrNo).ToList();
                if (billList.Count() > 0)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #endregion
    }
}
