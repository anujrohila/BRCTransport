using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRCTransport.Domain;
using BRCTransport.Database.ORM;

namespace BRCTransport.DAL
{
    public static class ConsigneeRepository
    {
        #region [Deceleration]

        #endregion

        #region [Method]

        public static int Save(tblConsigneeDTO tblConsigneeDTO)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var tblConsignee = tblConsigneeDTO.ToEntity();
                if (tblConsigneeDTO.ConsigneeId == 0)
                {
                    dbObject.tblConsignees.Add(tblConsignee);
                }
                else
                {
                    tblConsignee = dbObject.tblConsignees.Find(tblConsigneeDTO.ConsigneeId);
                    tblConsignee.ConsigneeName = tblConsigneeDTO.ConsigneeName;
                    tblConsignee.Address = tblConsigneeDTO.Address;
                    tblConsignee.PhoneNo = tblConsigneeDTO.PhoneNo;
                    tblConsignee.STNOCSTNO = tblConsigneeDTO.STNOCSTNO;
                    tblConsignee.TINNOVATNO = tblConsigneeDTO.TINNOVATNO;
                    tblConsignee.Description = tblConsigneeDTO.Description;
                }
                dbObject.SaveChanges();
                return tblConsignee.ConsigneeId;
            }
        }

        public static tblConsigneeDTO Get(int consigneeId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                return dbObject.tblConsignees.Find(consigneeId).ToDTO();
            }
        }

        public static List<tblConsigneeDTO> GetAll()
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                return dbObject.tblConsignees.ToList().ToDTOs();
            }
        }

        public static bool Delete(int consigneeId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var tblConsignee = dbObject.tblConsignees.Find(consigneeId);
                dbObject.tblConsignees.Remove(tblConsignee);
                dbObject.SaveChanges();
                return true;
            }
        }

        #endregion
    }
}
