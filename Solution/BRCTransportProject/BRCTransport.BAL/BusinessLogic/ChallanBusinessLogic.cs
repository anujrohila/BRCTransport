using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRCTransport.Domain;
using BRCTransport.DAL;

namespace BRCTransport.BAL
{
    public static class ChallanBusinessLogic
    {
        #region [Deceleration]

        #endregion

        #region [Method]

        public static int Save(tblChallanDTO tblChallanDTO)
        {
            return ChallanRepository.Save(tblChallanDTO);
        }

        public static bool CheckDuplicateChallanNo(int ChallanId, int ChallanNo)
        {
            return ChallanRepository.CheckDuplicateChallanNo(ChallanId, ChallanNo);
        }

        public static int GetChallanNo()
        {
            return ChallanRepository.GetChallanNo();
        }

        public static tblChallanDTO Get(int ChallanId)
        {
            return ChallanRepository.Get(ChallanId);
        }

        public static List<tblChallanDTO> GetAll()
        {
            return ChallanRepository.GetAll();
        }

        public static bool Delete(int ChallanId)
        {
            return ChallanRepository.Delete(ChallanId);
        }

        public static tblChallanEntryDTO GetChallanEntry(int ChallanOrderId)
        {
            return ChallanRepository.GetChallanEntry(ChallanOrderId);
        }

        public static List<tblChallanEntryDTO> GetChallanEntryList(int ChallanId)
        {
            return ChallanRepository.GetChallanEntryList(ChallanId);
        }

        public static int SaveChallanEntry(tblChallanEntryDTO tblChallanEntryDTO)
        {
            return ChallanRepository.SaveChallanEntry(tblChallanEntryDTO);
        }

        public static bool DeleteChallanEntry(int ChallanEntryOrderId)
        {
            return ChallanRepository.DeleteChallanEntry(ChallanEntryOrderId);
        }

        #endregion
    }

    //public class ChallanEntryLogic
    //{
    //    #region
    //    public static int Save(tblChallanEntryDTO tblChallanEntryDTO)
    //    {
    //        return ChallanEntryLogic.Save(tblChallanEntryDTO);

    //    }

    //    #endregion
    //}
}
