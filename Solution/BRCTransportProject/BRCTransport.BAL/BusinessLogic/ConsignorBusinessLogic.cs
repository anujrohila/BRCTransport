using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRCTransport.Domain;
using BRCTransport.DAL;

namespace BRCTransport.BAL
{
    public static class ConsignorBusinessLogic
    {
        #region [Deceleration]

        #endregion

        #region [Method]

        public static int Save(tblConsignorDTO tblConsignorDTO)
        {
            return ConsignorRepository.Save(tblConsignorDTO);
        }

        public static tblConsignorDTO Get(int consignorId)
        {
            return ConsignorRepository.Get(consignorId);
        }

        public static List<tblConsignorDTO> GetAll()
        {
            return ConsignorRepository.GetAll();
        }

        public static bool Delete(int consignorId)
        {
            return ConsignorRepository.Delete(consignorId);
        }

        public static bool CheckDuplicateCodeExists(string code, Int32 consignorId)
        {
            return ConsignorRepository.CheckDuplicateCodeExists(code, consignorId);
        }

        #endregion
    }
}
