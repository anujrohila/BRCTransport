using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRCTransport.Domain;
using BRCTransport.Database.ORM;

namespace BRCTransport.DAL
{
    public static class BillRepository
    {
        #region [Deceleration]

        #endregion

        #region [Method]

        public static int Save(tblBillDTO tblBillDTO)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var tblBillObject = tblBillDTO.ToEntity();
                if (tblBillDTO.BillId == 0)
                {
                    dbObject.tblBills.Add(tblBillObject);
                    if (tblBillDTO.BillEntryList != null)
                    {
                        foreach (var billEntry in tblBillDTO.BillEntryList)
                        {
                            billEntry.BillId = tblBillDTO.BillId;
                            dbObject.tblBillEntries.Add(billEntry.ToEntity());
                        }
                    }
                }
                else
                {
                    tblBillObject = dbObject.tblBills.Find(tblBillDTO.BillId);
                    tblBillObject.BillNo = tblBillDTO.BillNo;
                    tblBillObject.BillDate = tblBillDTO.BillDate;
                    tblBillObject.PartyId = tblBillDTO.PartyId;
                    tblBillObject.BranchCode = tblBillDTO.BranchCode;
                    tblBillObject.PaymentDueDate = tblBillDTO.PaymentDueDate;
                    tblBillObject.BillType = tblBillDTO.BillType;
                    tblBillObject.BasicOfChargesGC = tblBillDTO.BasicOfChargesGC;
                    tblBillObject.Enclosure = tblBillDTO.Enclosure;
                    tblBillObject.ServiceTaxThrough = tblBillDTO.ServiceTaxThrough;
                    tblBillObject.CheckedBy = tblBillDTO.CheckedBy;
                    tblBillObject.GrandTotal = tblBillDTO.GrandTotal;
                    tblBillObject.ServiceTaxRegdNo = tblBillDTO.ServiceTaxRegdNo;
                    List<tblBillEntry> entry = new List<tblBillEntry>();
                    entry = dbObject.tblBillEntries.Where(h => h.BillId == tblBillDTO.BillId).ToList();
                    foreach (var item in entry)
                    {
                        dbObject.tblBillEntries.Remove(item);
                    }
                    if (tblBillDTO.BillEntryList != null)
                    {
                        foreach (var billEntry in tblBillDTO.BillEntryList)
                        {
                            billEntry.BillId = tblBillDTO.BillId;
                            dbObject.tblBillEntries.Add(billEntry.ToEntity());
                        }
                    }
                }
                dbObject.SaveChanges();
                return tblBillObject.BillId;
            }
        }

        public static bool CheckDuplicateBillNo(int billId, int billNo)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var billList = dbObject.tblBills.Where(s => s.BillNo == billNo && s.BillId != billId).ToList();
                if (billList.Count() > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static int GetBillNo()
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                if (dbObject.tblBills.Count() > 0)
                {
                    return dbObject.tblBills.Max(bill => bill.BillNo);
                }
                else
                {
                    return 0;
                }
            }
        }

        public static tblBillDTO Get(int billId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                tblBillDTO temp = new tblBillDTO();
                temp = dbObject.tblBills.Find(billId).ToDTO();
                temp.BillEntryList = dbObject.tblBillEntries.Where(h => h.BillId == billId).ToList().ToDTOs();
                return temp;
            }
        }

        public static List<tblBillDTO> GetAll()
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                return dbObject.tblBills.ToList().ToDTOs();
            }
        }

        public static bool Delete(int billId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var tblBill = dbObject.tblBills.Find(billId);
                dbObject.tblBills.Remove(tblBill);
                var billEntrys = dbObject.tblBillEntries.Where(be => be.BillId == billId);
                foreach (var billEntry in billEntrys)
                {
                    dbObject.tblBillEntries.Remove(billEntry);
                }
                dbObject.SaveChanges();
                return true;
            }
        }

        public static tblBillEntryDTO GetBillEntry(int billOrderId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                return dbObject.tblBillEntries.Find(billOrderId).ToDTO();
            }
        }

        public static List<tblBillEntryDTO> GetBillEntryList(int billId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                return dbObject.tblBillEntries.Where(billEntry => billEntry.BillId == billId).ToDTOs();
            }
        }

        public static int SaveBillEntry(tblBillEntryDTO tblBillEntryDTO)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var tblBillEntryObject = tblBillEntryDTO.ToEntity();
                if (tblBillEntryDTO.BillOrderId == 0)
                {
                    dbObject.tblBillEntries.Add(tblBillEntryObject);
                }
                else
                {
                    tblBillEntryObject = dbObject.tblBillEntries.Find(tblBillEntryDTO.BillOrderId);
                    tblBillEntryObject.BillId = tblBillEntryDTO.BillId;
                    tblBillEntryObject.BookingOldBrCode = tblBillEntryDTO.BookingOldBrCode;
                    tblBillEntryObject.OldBillNo = tblBillEntryDTO.OldBillNo;
                    tblBillEntryObject.OldBillDate = tblBillEntryDTO.OldBillDate;
                    tblBillEntryObject.DestnCode = tblBillEntryDTO.DestnCode;
                    tblBillEntryObject.Particulars = tblBillEntryDTO.Particulars;
                    tblBillEntryObject.ChargedWeight = tblBillEntryDTO.ChargedWeight;
                    tblBillEntryObject.Rate = tblBillEntryDTO.Rate;
                    tblBillEntryObject.Amount = tblBillEntryDTO.Amount;
                }
                dbObject.SaveChanges();
                return tblBillEntryObject.BillOrderId;
            }
        }

        public static bool DeleteBillEntry(int billEntryOrderId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var tblBillEntry = dbObject.tblBillEntries.Find(billEntryOrderId);
                dbObject.tblBillEntries.Remove(tblBillEntry);
                dbObject.SaveChanges();
                return true;
            }
        }

        //public static List<tblBillDTO> GetPendingBills(int bill)
        //{
        //    using (var dbObject = new BRCTransportDBEntities())
        //    {
        //        return dbObject.tblBills.ToList().ToDTOs();
        //    }
        //}


        #endregion
    }
}
