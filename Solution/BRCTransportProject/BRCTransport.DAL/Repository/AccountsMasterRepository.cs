using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRCTransport.Domain;
using BRCTransport.Database.ORM;

namespace BRCTransport.DAL
{
    public static class AccountsMasterRepository
    {
        #region [Deceleration]

        #endregion

        #region [Method]

        public static int Save(tblAccountsMasterDTO tblAccountsMasterDTO)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var tblAccountsMaster = tblAccountsMasterDTO.ToEntity();
                if (tblAccountsMasterDTO.AccountId == 0)
                {
                    dbObject.tblAccountsMasters.Add(tblAccountsMaster);
                }
                else
                {
                    tblAccountsMaster = dbObject.tblAccountsMasters.Find(tblAccountsMasterDTO.AccountId);
                    tblAccountsMaster.AccountName = tblAccountsMasterDTO.AccountName;
                    tblAccountsMaster.AccountType = tblAccountsMasterDTO.AccountType;
                    tblAccountsMaster.AccountNo = tblAccountsMasterDTO.AccountNo;
                    tblAccountsMaster.Addrees = tblAccountsMasterDTO.Addrees;
                    tblAccountsMaster.PhoneNo = tblAccountsMasterDTO.PhoneNo;
                    tblAccountsMaster.OpeningBalance = tblAccountsMasterDTO.OpeningBalance;
                    tblAccountsMaster.OpeningDate = tblAccountsMasterDTO.OpeningDate;
                    tblAccountsMaster.Description = tblAccountsMasterDTO.Description;
                }
                dbObject.SaveChanges();
                return tblAccountsMaster.AccountId;
            }
        }

        public static tblAccountsMasterDTO Get(int companyId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                return dbObject.tblAccountsMasters.Find(companyId).ToDTO();
            }
        }

        public static List<tblAccountsMasterDTO> GetAll()
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                return dbObject.tblAccountsMasters.ToList().ToDTOs();
            }
        }

        public static bool Delete(int companyId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var tblAccountsMaster = dbObject.tblAccountsMasters.Find(companyId);
                dbObject.tblAccountsMasters.Remove(tblAccountsMaster);
                dbObject.SaveChanges();
                return true;
            }
        }

        public static bool CheckDuplicateAccount(string accountName, int accountId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var accountsMastersList = dbObject.tblAccountsMasters.Where(s => string.Compare(s.AccountName, accountName, StringComparison.CurrentCultureIgnoreCase) == 0 && s.AccountId != accountId).ToList();
                if (accountsMastersList.Count() > 0)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion
    }
}
