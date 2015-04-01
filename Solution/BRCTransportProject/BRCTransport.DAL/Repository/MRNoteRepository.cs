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

    }
}
