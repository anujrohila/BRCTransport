using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRCTransport.Domain;
using BRCTransport.DAL;

namespace BRCTransport.BAL
{
    public static class ConsigneeBusinessLogic
    {
        #region [Deceleration]

        #endregion

        #region [Method]

        public static int Save(tblConsigneeDTO tblConsigneeDTO)
        {
            return ConsigneeRepository.Save(tblConsigneeDTO);
        }

        public static tblConsigneeDTO Get(int consigneeId)
        {
            return ConsigneeRepository.Get(consigneeId);
        }

        public static List<tblConsigneeDTO> GetAll()
        {
            return ConsigneeRepository.GetAll();
        }

        public static bool Delete(int consigneeId)
        {
            return ConsigneeRepository.Delete(consigneeId);
        }

        #endregion
    }
}
