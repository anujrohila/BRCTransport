using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRCTransport.Domain;
using BRCTransport.Database.ORM;

namespace BRCTransport.DAL
{
    public static class ConsignorRepository
    {
        #region [Deceleration]

        #endregion

        #region [Method]

        public static int Save(tblConsignorDTO tblConsignorDTO)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var tblConsignor = tblConsignorDTO.ToEntity();
                if (tblConsignorDTO.ConsignorId == 0)
                {
                    dbObject.tblConsignors.Add(tblConsignor);
                }
                else
                {
                    tblConsignor = dbObject.tblConsignors.Find(tblConsignorDTO.ConsignorId);
                    tblConsignor.ConsignorName = tblConsignorDTO.ConsignorName;
                    tblConsignor.Address = tblConsignorDTO.Address;
                    tblConsignor.PhoneNo = tblConsignorDTO.PhoneNo;
                    tblConsignor.STNOCSTNO = tblConsignorDTO.STNOCSTNO;
                    tblConsignor.TINNOVATNO = tblConsignorDTO.TINNOVATNO;
                    tblConsignor.Description = tblConsignorDTO.Description;
                }
                dbObject.SaveChanges();
                return tblConsignor.ConsignorId;
            }
        }

        public static tblConsignorDTO Get(int consignorId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                return dbObject.tblConsignors.Find(consignorId).ToDTO();
            }
        }

        public static List<tblConsignorDTO> GetAll()
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                return dbObject.tblConsignors.ToList().ToDTOs();
            }
        }

        public static bool Delete(int consignorId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var tblConsignor = dbObject.tblConsignors.Find(consignorId);
                dbObject.tblConsignors.Remove(tblConsignor);
                dbObject.SaveChanges();
                return true;
            }
        }

        public static bool CheckDuplicateCodeExists(string code, Int32 consignorId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var consignorList = dbObject.tblConsignors.Where(s => s.Code == code && s.ConsignorId != consignorId).ToList();
                if (consignorList.Count() > 0)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion
    }
}
