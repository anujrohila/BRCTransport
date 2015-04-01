using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRCTransport.Domain;
using BRCTransport.Database.ORM;

namespace BRCTransport.DAL
{
    public static class TransactionRepository
    {
        #region [Deceleration]

        #endregion

        #region [Method]

        public static int Save(tblTransactionDTO tblTransactionDTO)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var tblTransaction = tblTransactionDTO.ToEntity();
                if (tblTransactionDTO.TransactionId == 0)
                {
                    dbObject.tblTransactions.Add(tblTransaction);
                }
                else
                {
                    tblTransaction = dbObject.tblTransactions.Find(tblTransactionDTO.TransactionId);
                    tblTransaction.AccountId = tblTransactionDTO.AccountId;
                    tblTransaction.TDate = tblTransactionDTO.TDate;
                    tblTransaction.DrAmount = tblTransactionDTO.DrAmount;
                    tblTransaction.CrAmount = tblTransactionDTO.CrAmount;
                    tblTransaction.Recievedby = tblTransactionDTO.Recievedby;
                    tblTransaction.PaidBy = tblTransactionDTO.PaidBy;
                    tblTransaction.Description = tblTransactionDTO.Description;
                    tblTransaction.ChequeNo = tblTransactionDTO.ChequeNo;
                    tblTransaction.ChequeDate = tblTransactionDTO.ChequeDate;
                }
                dbObject.SaveChanges();
                return tblTransaction.TransactionId;
            }
        }

        public static tblTransactionDTO Get(int transactionId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                return (from transaction in dbObject.tblTransactions
                        where(transaction.TransactionId == transactionId)
                        select new tblTransactionDTO
                        {
                            AccountId = transaction.AccountId,
                            AccountName = transaction.tblAccountsMaster.AccountName,
                            ChequeDate = transaction.ChequeDate,
                            ChequeNo = transaction.ChequeNo,
                            CrAmount = transaction.CrAmount,
                            DrAmount = transaction.DrAmount,
                            Description = transaction.Description,
                            PaidBy = transaction.PaidBy,
                            Recievedby = transaction.Recievedby,
                            TDate = transaction.TDate,
                            TransactionId = transaction.TransactionId,
                            TransactionType = transaction.DrAmount == 0 ? 1 : 2,
                            Amount = transaction.DrAmount == 0 ? transaction.CrAmount : transaction.DrAmount
                        }).ToList().FirstOrDefault();
            }
        }

        public static List<tblTransactionDTO> GetAll()
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                return (from transaction in dbObject.tblTransactions
                        select new tblTransactionDTO
                        {
                            AccountId = transaction.AccountId,
                            AccountName = transaction.tblAccountsMaster.AccountName, 
                            ChequeDate = transaction.ChequeDate,
                            ChequeNo = transaction.ChequeNo,
                            CrAmount = transaction.CrAmount,
                            DrAmount = transaction.DrAmount,
                            Description = transaction.Description,
                            PaidBy = transaction.PaidBy,
                            Recievedby = transaction.Recievedby,
                            TDate = transaction.TDate,
                            TransactionId = transaction.TransactionId,
                            TransactionType = transaction.DrAmount == 0 ? 1 : 2,
                            Amount = transaction.DrAmount == 0 ? transaction.CrAmount : transaction.DrAmount
                        }).ToList();
            }
        }

        public static bool Delete(int transactionId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var tblTransaction = dbObject.tblTransactions.Find(transactionId);
                dbObject.tblTransactions.Remove(tblTransaction);
                dbObject.SaveChanges();
                return true;
            }
        }

        #endregion
    }
}
