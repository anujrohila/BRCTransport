using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRCTransport.Domain;
using BRCTransport.DAL;

namespace BRCTransport.BAL
{
    public static class AccountsMasterBusinessLogic
    {
        #region [Deceleration]

        #endregion

        #region [Method]

        public static int Save(tblAccountsMasterDTO tblAccountsMasterDTO)
        {
            return AccountsMasterRepository.Save(tblAccountsMasterDTO);
        }

        public static tblAccountsMasterDTO Get(int AccountsMasterId)
        {
            return AccountsMasterRepository.Get(AccountsMasterId);
        }

        public static List<tblAccountsMasterDTO> GetAll()
        {
            return AccountsMasterRepository.GetAll();
        }

        public static bool Delete(int AccountsMasterId)
        {
            return AccountsMasterRepository.Delete(AccountsMasterId);
        }

        public static bool CheckDuplicateAccount(string accountName, int accountId)
        {
            return AccountsMasterRepository.CheckDuplicateAccount(accountName, accountId);
        }

        #endregion
    }
}
