using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRCTransport.Domain;
using BRCTransport.DAL;

namespace BRCTransport.BAL
{
    public static class MRNoteBusinessLogic
    {
        #region [Deceleration]

        #endregion

        #region [Method]

        public static int Save(tblMRNoteDTO tblMRNoteDTO)
        {
            return MRNoteRepository.Save(tblMRNoteDTO);
        }

        public static bool CheckDuplicateMRNo(int mrId, int mrNo)
        {
            return MRNoteRepository.CheckDuplicateMRNo(mrId, mrNo);
        }

        public static int GetMRNo()
        {
            return MRNoteRepository.GetMRNo();
        }

        public static tblMRNoteDTO Get(int MRNoteId)
        {
            return MRNoteRepository.Get(MRNoteId);
        }

        public static List<tblMRNoteDTO> GetAll()
        {
            return MRNoteRepository.GetAll();
        }

        public static bool Delete(int MRNoteId)
        {
            return MRNoteRepository.Delete(MRNoteId);
        }

        public static tblBillDTO GetMRNoteBillDetail(int billNo)
        {
            return MRNoteRepository.GetMRNoteBillDetail(billNo);
        }

        public static List<tblMRNoteDTO> GetBillMRNote(int billId)
        {
            return MRNoteRepository.GetBillMRNote(billId);
        }

        #endregion
    }
}
