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
    /// Assembler for <see cref="tblConsignee"/> and <see cref="tblConsigneeDTO"/>.
    /// </summary>
    public static partial class tblConsigneeAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="tblConsigneeDTO"/> converted from <see cref="tblConsignee"/>.</param>
        static partial void OnDTO(this tblConsignee entity, tblConsigneeDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tblConsignee"/> converted from <see cref="tblConsigneeDTO"/>.</param>
        static partial void OnEntity(this tblConsigneeDTO dto, tblConsignee entity);

        /// <summary>
        /// Converts this instance of <see cref="tblConsigneeDTO"/> to an instance of <see cref="tblConsignee"/>.
        /// </summary>
        /// <param name="dto"><see cref="tblConsigneeDTO"/> to convert.</param>
        public static tblConsignee ToEntity(this tblConsigneeDTO dto)
        {
            if (dto == null) return null;

            var entity = new tblConsignee();

            entity.ConsigneeId = dto.ConsigneeId;
            entity.ConsigneeName = dto.ConsigneeName;
            entity.Address = dto.Address;
            entity.PhoneNo = dto.PhoneNo;
            entity.STNOCSTNO = dto.STNOCSTNO;
            entity.TINNOVATNO = dto.TINNOVATNO;
            entity.Description = dto.Description;
            entity.CreationDate = dto.CreationDate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="tblConsignee"/> to an instance of <see cref="tblConsigneeDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="tblConsignee"/> to convert.</param>
        public static tblConsigneeDTO ToDTO(this tblConsignee entity)
        {
            if (entity == null) return null;

            var dto = new tblConsigneeDTO();

            dto.ConsigneeId = entity.ConsigneeId;
            dto.ConsigneeName = entity.ConsigneeName;
            dto.Address = entity.Address;
            dto.PhoneNo = entity.PhoneNo;
            dto.STNOCSTNO = entity.STNOCSTNO;
            dto.TINNOVATNO = entity.TINNOVATNO;
            dto.Description = entity.Description;
            dto.CreationDate = entity.CreationDate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="tblConsigneeDTO"/> to an instance of <see cref="tblConsignee"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tblConsignee> ToEntities(this IEnumerable<tblConsigneeDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tblConsignee"/> to an instance of <see cref="tblConsigneeDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<tblConsigneeDTO> ToDTOs(this IEnumerable<tblConsignee> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
