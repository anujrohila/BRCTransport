using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRCTransport.Domain;
using BRCTransport.DAL;

namespace BRCTransport.BAL
{
    public static class ConsignmentNoteBusinessLogic
    {
        #region [Deceleration]

        #endregion

        #region [Method]

        public static int Save(tblConsignmentNoteDTO tblConsignmentNoteDTO)
        {
            return ConsignmentNoteRepository.Save(tblConsignmentNoteDTO);
        }

        public static bool CheckDuplicateConsignmentNoteNo(int ConsignmentId, int ConsignmentNoteNo)
        {
            return ConsignmentNoteRepository.CheckDuplicateConsignmentNoteNo(ConsignmentId, ConsignmentNoteNo);
        }

        public static int GetConsignmentNoteNo()
        {
            return ConsignmentNoteRepository.GetConsignmentNoteNo();
        }

        public static tblConsignmentNoteDTO Get(int ConsignmentNoteId)
        {
            return ConsignmentNoteRepository.Get(ConsignmentNoteId);
        }

        public static List<tblConsignmentNoteDTO> GetAll()
        {
            return ConsignmentNoteRepository.GetAll();
        }

        public static bool Delete(int ConsignmentId)
        {
            return ConsignmentNoteRepository.Delete(ConsignmentId);
        }

        #endregion
    }
}
