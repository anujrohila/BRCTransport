using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRCTransport.Domain;
using BRCTransport.DAL;

namespace BRCTransport.BAL
{
    public static class BillBusinessLogic
    {
        #region [Deceleration]

        #endregion

        #region [Method]

        public static int Save(tblBillDTO tblBillDTO)
        {
            return BillRepository.Save(tblBillDTO);
        }

        public static bool CheckDuplicateBillNo(int billId, int billNo)
        {
            return BillRepository.CheckDuplicateBillNo(billId, billNo);
        }

        public static int GetBillNo()
        {
            return BillRepository.GetBillNo();
        }

        public static tblBillDTO Get(int billId)
        {
            return BillRepository.Get(billId);
        }

        public static List<tblBillDTO> GetAll()
        {
            return BillRepository.GetAll();
        }

        public static bool Delete(int billId)
        {
            return BillRepository.Delete(billId);
        }

        public static tblBillEntryDTO GetBillEntry(int billOrderId)
        {
            return BillRepository.GetBillEntry(billOrderId);
        }

        public static List<tblBillEntryDTO> GetBillEntryList(int billId)
        {
            return BillRepository.GetBillEntryList(billId);
        }

        public static int SaveBillEntry(tblBillEntryDTO tblBillEntryDTO)
        {
            return BillRepository.SaveBillEntry(tblBillEntryDTO);
        }

        public static bool DeleteBillEntry(int billEntryOrderId)
        {
            return BillRepository.DeleteBillEntry(billEntryOrderId);
        }

        #endregion
    }
}
