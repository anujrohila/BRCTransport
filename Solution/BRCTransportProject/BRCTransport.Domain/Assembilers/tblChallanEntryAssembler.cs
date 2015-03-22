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
    /// Assembler for <see cref="tblChallanEntry"/> and <see cref="tblChallanEntryDTO"/>.
    /// </summary>
    public static partial class tblChallanEntryAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="tblChallanEntryDTO"/> converted from <see cref="tblChallanEntry"/>.</param>
        static partial void OnDTO(this tblChallanEntry entity, tblChallanEntryDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tblChallanEntry"/> converted from <see cref="tblChallanEntryDTO"/>.</param>
        static partial void OnEntity(this tblChallanEntryDTO dto, tblChallanEntry entity);

        /// <summary>
        /// Converts this instance of <see cref="tblChallanEntryDTO"/> to an instance of <see cref="tblChallanEntry"/>.
        /// </summary>
        /// <param name="dto"><see cref="tblChallanEntryDTO"/> to convert.</param>
        public static tblChallanEntry ToEntity(this tblChallanEntryDTO dto)
        {
            if (dto == null) return null;

            var entity = new tblChallanEntry();

            entity.ChallanEntryNo = dto.ChallanEntryNo;
            entity.ChallanId = dto.ChallanId;
            entity.BkgStnCode = dto.BkgStnCode;
            entity.CNNoWithAlphaCode = dto.CNNoWithAlphaCode;
            entity.PackagesNos = dto.PackagesNos;
            entity.PackagesMethod = dto.PackagesMethod;
            entity.SaidToContain = dto.SaidToContain;
            entity.ActualWeightKgs = dto.ActualWeightKgs;
            entity.DestinationName = dto.DestinationName;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="tblChallanEntry"/> to an instance of <see cref="tblChallanEntryDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="tblChallanEntry"/> to convert.</param>
        public static tblChallanEntryDTO ToDTO(this tblChallanEntry entity)
        {
            if (entity == null) return null;

            var dto = new tblChallanEntryDTO();

            dto.ChallanEntryNo = entity.ChallanEntryNo;
            dto.ChallanId = entity.ChallanId ?? 0;
            dto.BkgStnCode = entity.BkgStnCode;
            dto.CNNoWithAlphaCode = entity.CNNoWithAlphaCode;
            dto.PackagesNos = entity.PackagesNos;
            dto.PackagesMethod = entity.PackagesMethod;
            dto.SaidToContain = entity.SaidToContain;
            dto.ActualWeightKgs = entity.ActualWeightKgs;
            dto.DestinationName = entity.DestinationName;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="tblChallanEntryDTO"/> to an instance of <see cref="tblChallanEntry"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tblChallanEntry> ToEntities(this IEnumerable<tblChallanEntryDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tblChallanEntry"/> to an instance of <see cref="tblChallanEntryDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<tblChallanEntryDTO> ToDTOs(this IEnumerable<tblChallanEntry> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
