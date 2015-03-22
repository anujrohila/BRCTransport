using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BRCTransport.Domain;
using BRCTransport.Database.ORM;

namespace BRCTransport.DAL
{
    public static class ChallanRepository
    {
        #region [Deceleration]

        #endregion

        #region [Method]

        public static int Save(tblChallanDTO tblChallanDTO)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var tblChallanObject = tblChallanDTO.ToEntity();
                if (tblChallanDTO.ChallanId == 0)
                {
                    dbObject.tblChallans.Add(tblChallanObject);
                    if (tblChallanDTO.ChallanEntryList != null)
                    {
                        foreach (var ChallanEntry in tblChallanDTO.ChallanEntryList)
                        {
                            dbObject.tblChallanEntries.Add(ChallanEntry.ToEntity());
                        }
                    }
                }
                else
                {
                    tblChallanObject = dbObject.tblChallans.Find(tblChallanDTO.ChallanId);
                    tblChallanObject.ChallanNo = tblChallanDTO.ChallanNo;
                    tblChallanObject.ChallanDateTime = tblChallanDTO.ChallanDateTime;
                    tblChallanObject.VehicleNo = tblChallanDTO.VehicleNo;
                    tblChallanObject.VehicleType = tblChallanDTO.VehicleType;
                    tblChallanObject.VechicleMake = tblChallanDTO.VechicleMake;
                    tblChallanObject.VehicleModel = tblChallanDTO.VehicleModel;
                    tblChallanObject.VehicleNoOfPointLoading = tblChallanDTO.VehicleNoOfPointLoading;
                    tblChallanObject.Vehicle4NoOfPointUnLoading = tblChallanDTO.Vehicle4NoOfPointUnLoading;
                    tblChallanObject.VehicleFleetCode = tblChallanDTO.VehicleFleetCode;
                    tblChallanObject.FromBrCode = tblChallanDTO.FromBrCode;
                    tblChallanObject.LoadedForm = tblChallanDTO.LoadedForm;
                    tblChallanObject.ToBrCode = tblChallanDTO.ToBrCode;
                    tblChallanObject.Destination = tblChallanDTO.Destination;
                    tblChallanObject.DistanceKM = tblChallanDTO.DistanceKM;
                    tblChallanObject.ScheduleDateofActual = tblChallanDTO.ScheduleDateofActual;
                    tblChallanObject.VechicleEngineNo = tblChallanDTO.VechicleEngineNo;
                    tblChallanObject.VechicleChassisNo = tblChallanDTO.VechicleChassisNo;
                    tblChallanObject.DriverName = tblChallanDTO.DriverName;
                    tblChallanObject.DriverMobileNo = tblChallanDTO.DriverMobileNo;
                    tblChallanObject.DriverAddress = tblChallanDTO.DriverAddress;
                    tblChallanObject.TaxTokenNo = tblChallanDTO.TaxTokenNo;
                    tblChallanObject.TaxTokenNoValidUpto = tblChallanDTO.TaxTokenNoValidUpto;
                    tblChallanObject.TaxTokenNoIssuedFrom = tblChallanDTO.TaxTokenNoIssuedFrom;
                    tblChallanObject.DriverLicenseNo = tblChallanDTO.DriverLicenseNo;
                    tblChallanObject.LicenseIssuedFrom = tblChallanDTO.LicenseIssuedFrom;
                    tblChallanObject.LicenseValidUpto = tblChallanDTO.LicenseValidUpto;
                    tblChallanObject.RoadPermitNo = tblChallanDTO.RoadPermitNo;
                    tblChallanObject.RoadPermitValidUpto = tblChallanDTO.RoadPermitValidUpto;
                    tblChallanObject.VechicleOwnerName = tblChallanDTO.VechicleOwnerName;
                    tblChallanObject.VechicleOwnerMobileNo = tblChallanDTO.VechicleOwnerMobileNo;
                    tblChallanObject.VechicleOwnerPanNo = tblChallanDTO.VechicleOwnerPanNo;
                    tblChallanObject.VechicleOwnerAddress = tblChallanDTO.VechicleOwnerAddress;
                    tblChallanObject.InsPolicyNo = tblChallanDTO.InsPolicyNo;
                    tblChallanObject.InsCoWithStn = tblChallanDTO.InsCoWithStn;
                    tblChallanObject.VechicleEngagedByNameWithEmpCode1 = tblChallanDTO.VechicleEngagedByNameWithEmpCode1;
                    tblChallanObject.VechicleEngagedByNameWithEmpCode2 = tblChallanDTO.VechicleEngagedByNameWithEmpCode2;
                    tblChallanObject.VechicleAgentName = tblChallanDTO.VechicleAgentName;
                    tblChallanObject.VechicleMobileNo = tblChallanDTO.VechicleMobileNo;
                    tblChallanObject.VechicleAgentAddress = tblChallanDTO.VechicleAgentAddress;
                    tblChallanObject.VechicleFinancierDetails = tblChallanDTO.VechicleFinancierDetails;
                    tblChallanObject.BrokerLoadingAdviceNoDate = tblChallanDTO.BrokerLoadingAdviceNoDate;
                    tblChallanObject.GrandTotalPKG = tblChallanDTO.GrandTotalPKG;
                    tblChallanObject.GrandTotalKGS = tblChallanDTO.GrandTotalKGS;
                    tblChallanObject.MaterialUnLoadingBy = tblChallanDTO.MaterialUnLoadingBy;
                    tblChallanObject.PayableTotalPackages = tblChallanDTO.PayableTotalPackages;
                    tblChallanObject.PayableChargedWeight = tblChallanDTO.PayableChargedWeight;
                    tblChallanObject.PayableRatePerTon = tblChallanDTO.PayableRatePerTon;
                    tblChallanObject.TotalLorryHire = tblChallanDTO.TotalLorryHire;
                    tblChallanObject.ITDSDeduction = tblChallanDTO.ITDSDeduction;
                    tblChallanObject.PartyLorryHire = tblChallanDTO.PartyLorryHire;
                    tblChallanObject.BalanceLorryHire = tblChallanDTO.BalanceLorryHire;
                }
                dbObject.SaveChanges();
                return tblChallanObject.ChallanId;
            }
        }

        public static bool CheckDuplicateChallanNo(int ChallanId, int ChallanNo)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var ChallanList = dbObject.tblChallans.Where(s => s.ChallanNo == ChallanNo && s.ChallanId != ChallanId).ToList();
                if (ChallanList.Count() > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static int GetChallanNo()
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                if (dbObject.tblChallans.Count() > 0)
                {
                    return dbObject.tblChallans.Max(Challan => Challan.ChallanNo ?? 0);
                }
                else
                {
                    return 0;
                }
            }
        }

        public static tblChallanDTO Get(int ChallanId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                return dbObject.tblChallans.Find(ChallanId).ToDTO();
            }
        }

        public static List<tblChallanDTO> GetAll()
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                return dbObject.tblChallans.ToList().ToDTOs();
            }
        }

        public static bool Delete(int ChallanId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var tblChallan = dbObject.tblChallans.Find(ChallanId);
                dbObject.tblChallans.Remove(tblChallan);
                var ChallanEntrys = dbObject.tblChallanEntries.Where(be => be.ChallanId == ChallanId);
                foreach (var ChallanEntry in ChallanEntrys)
                {
                    dbObject.tblChallanEntries.Remove(ChallanEntry);
                }
                dbObject.SaveChanges();
                return true;
            }
        }

        public static tblChallanEntryDTO GetChallanEntry(int ChallanOrderId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                return dbObject.tblChallanEntries.Find(ChallanOrderId).ToDTO();
            }
        }

        public static List<tblChallanEntryDTO> GetChallanEntryList(int ChallanId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                return dbObject.tblChallanEntries.Where(ChallanEntry => ChallanEntry.ChallanId == ChallanId).ToDTOs();
            }
        }

        public static int SaveChallanEntry(tblChallanEntryDTO tblChallanEntryDTO)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var tblChallanEntryObject = tblChallanEntryDTO.ToEntity();
                if (tblChallanEntryDTO.ChallanEntryNo == 0)
                {
                    dbObject.tblChallanEntries.Add(tblChallanEntryObject);
                }
                else
                {
                    tblChallanEntryObject = dbObject.tblChallanEntries.Find(tblChallanEntryDTO.ChallanEntryNo);
                    tblChallanEntryObject.ChallanId = tblChallanEntryDTO.ChallanId;
                    tblChallanEntryObject.ChallanId = tblChallanEntryDTO.ChallanId;
                    tblChallanEntryObject.BkgStnCode = tblChallanEntryDTO.BkgStnCode;
                    tblChallanEntryObject.CNNoWithAlphaCode = tblChallanEntryDTO.CNNoWithAlphaCode;
                    tblChallanEntryObject.PackagesNos = tblChallanEntryDTO.PackagesNos;
                    tblChallanEntryObject.PackagesMethod = tblChallanEntryDTO.PackagesMethod;
                    tblChallanEntryObject.SaidToContain = tblChallanEntryDTO.SaidToContain;
                    tblChallanEntryObject.ActualWeightKgs = tblChallanEntryDTO.ActualWeightKgs;
                    tblChallanEntryObject.DestinationName = tblChallanEntryDTO.DestinationName;
                }
                dbObject.SaveChanges();
                return tblChallanEntryObject.ChallanEntryNo;
            }
        }

        public static bool DeleteChallanEntry(int ChallanEntryOrderId)
        {
            using (var dbObject = new BRCTransportDBEntities())
            {
                var tblChallanEntry = dbObject.tblChallanEntries.Find(ChallanEntryOrderId);
                dbObject.tblChallanEntries.Remove(tblChallanEntry);
                dbObject.SaveChanges();
                return true;
            }
        }

        #endregion
    }
}
