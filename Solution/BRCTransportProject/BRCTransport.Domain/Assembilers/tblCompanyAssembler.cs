//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2014/09/28 - 16:22:55
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using BRCTransport.Domain;
using BRCTransport.Database.ORM;

namespace BRCTransport.Domain
{

    /// <summary>
    /// Assembler for <see cref="tblCompany"/> and <see cref="tblCompanyDTO"/>.
    /// </summary>
    public static partial class tblCompanyAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="tblCompanyDTO"/> converted from <see cref="tblCompany"/>.</param>
        static partial void OnDTO(this tblCompany entity, tblCompanyDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tblCompany"/> converted from <see cref="tblCompanyDTO"/>.</param>
        static partial void OnEntity(this tblCompanyDTO dto, tblCompany entity);

        /// <summary>
        /// Converts this instance of <see cref="tblCompanyDTO"/> to an instance of <see cref="tblCompany"/>.
        /// </summary>
        /// <param name="dto"><see cref="tblCompanyDTO"/> to convert.</param>
        public static tblCompany ToEntity(this tblCompanyDTO dto)
        {
            if (dto == null) return null;

            var entity = new tblCompany();

            entity.CompanyId = dto.CompanyId;
            entity.CompanyName = dto.CompanyName;
            entity.Address = dto.Address;
            entity.PhoneNo = dto.PhoneNo;
            entity.Description = dto.Description;
            entity.ServiceTaxRegdNo = dto.ServiceTaxRegdNo;
            entity.PolicyNo = dto.PolicyNo;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="tblCompany"/> to an instance of <see cref="tblCompanyDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="tblCompany"/> to convert.</param>
        public static tblCompanyDTO ToDTO(this tblCompany entity)
        {
            if (entity == null) return null;

            var dto = new tblCompanyDTO();

            dto.CompanyId = entity.CompanyId;
            dto.CompanyName = entity.CompanyName;
            dto.Address = entity.Address;
            dto.PhoneNo = entity.PhoneNo;
            dto.Description = entity.Description;
            dto.ServiceTaxRegdNo = entity.ServiceTaxRegdNo;
            dto.PolicyNo = entity.PolicyNo;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="tblCompanyDTO"/> to an instance of <see cref="tblCompany"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tblCompany> ToEntities(this IEnumerable<tblCompanyDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tblCompany"/> to an instance of <see cref="tblCompanyDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<tblCompanyDTO> ToDTOs(this IEnumerable<tblCompany> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
