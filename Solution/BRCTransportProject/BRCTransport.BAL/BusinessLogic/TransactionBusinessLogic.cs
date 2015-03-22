using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRCTransport.Domain;
using BRCTransport.DAL;

namespace BRCTransport.BAL
{
    public static class TransactionBusinessLogic
    {
        #region [Deceleration]

        #endregion

        #region [Method]

        public static int Save(tblTransactionDTO tblTransactionDTO)
        {
            return TransactionRepository.Save(tblTransactionDTO);
        }

        public static tblTransactionDTO Get(int transactionId)
        {
            return TransactionRepository.Get(transactionId);
        }

        public static List<tblTransactionDTO> GetAll()
        {
            return TransactionRepository.GetAll();
        }

        public static bool Delete(int transactionId)
        {
            return TransactionRepository.Delete(transactionId);
        }

        #endregion
    }
}
