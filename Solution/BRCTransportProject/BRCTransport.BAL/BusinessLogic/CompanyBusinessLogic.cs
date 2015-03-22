using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRCTransport.Domain;
using BRCTransport.DAL;

namespace BRCTransport.BAL
{
    public static class CompanyBusinessLogic
    {
        #region [Deceleration]

        #endregion

        #region [Method]

        public static int Save(tblCompanyDTO tblCompanyDTO)
        {
            return CompanyRepository.Save(tblCompanyDTO);
        }

        public static tblCompanyDTO Get(int companyId)
        {
            return CompanyRepository.Get(companyId);
        }

        public static List<tblCompanyDTO> GetAll()
        {
            return CompanyRepository.GetAll();
        }

        public static bool Delete(int companyId)
        {
            return CompanyRepository.Delete(companyId);
        }

        #endregion
    }
}
