using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRCTransport.Domain;
using BRCTransport.Database.ORM;

namespace BRCTransport.DAL
{
    public static class CompanyRepository
    {
        #region [Deceleration]

        #endregion

        #region [Method]

        public static int Save(tblCompanyDTO tblCompanyDTO)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var tblCompany = tblCompanyDTO.ToEntity();
                if (tblCompanyDTO.CompanyId == 0)
                {
                    dbObject.tblCompanies.Add(tblCompany);
                }
                else
                {
                    tblCompany = dbObject.tblCompanies.Find(tblCompanyDTO.CompanyId);
                    tblCompany.CompanyName = tblCompanyDTO.CompanyName;
                    tblCompany.Address = tblCompanyDTO.Address;
                    tblCompany.PhoneNo = tblCompanyDTO.PhoneNo;
                    tblCompany.Description = tblCompanyDTO.Description;
                    tblCompany.ServiceTaxRegdNo = tblCompanyDTO.ServiceTaxRegdNo;
                    tblCompany.PolicyNo = tblCompanyDTO.PolicyNo;
                }
                dbObject.SaveChanges();
                return tblCompany.CompanyId;
            }
        }

        public static tblCompanyDTO Get(int companyId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                return dbObject.tblCompanies.Find(companyId).ToDTO();
            }
        }

        public static List<tblCompanyDTO> GetAll()
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                return dbObject.tblCompanies.ToList().ToDTOs();
            }
        }

        public static bool Delete(int companyId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var tblCompanie = dbObject.tblCompanies.Find(companyId);
                dbObject.tblCompanies.Remove(tblCompanie);
                dbObject.SaveChanges();
                return true;
            }
        }

        #endregion
    }
}
