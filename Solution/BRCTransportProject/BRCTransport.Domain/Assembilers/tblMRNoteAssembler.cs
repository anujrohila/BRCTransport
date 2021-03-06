//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.2 (entitiestodtos.codeplex.com).
//     Timestamp: 2014-12-15 - 17:08:14
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
    /// Assembler for <see cref="tblMRNote"/> and <see cref="tblMRNoteDTO"/>.
    /// </summary>
    public static partial class tblMRNoteAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="tblMRNoteDTO"/> converted from <see cref="tblMRNote"/>.</param>
        static partial void OnDTO(this tblMRNote entity, tblMRNoteDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tblMRNote"/> converted from <see cref="tblMRNoteDTO"/>.</param>
        static partial void OnEntity(this tblMRNoteDTO dto, tblMRNote entity);

        /// <summary>
        /// Converts this instance of <see cref="tblMRNoteDTO"/> to an instance of <see cref="tblMRNote"/>.
        /// </summary>
        /// <param name="dto"><see cref="tblMRNoteDTO"/> to convert.</param>
        public static tblMRNote ToEntity(this tblMRNoteDTO dto)
        {
            if (dto == null) return null;

            var entity = new tblMRNote();

            entity.MRId = dto.MRId;
            entity.MrNo = dto.MrNo;
            entity.BillId = dto.BillId;
            entity.MRDate = dto.MRDate;
            entity.RecievedFrom = dto.RecievedFrom;
            entity.LocationFrom = dto.LocationFrom;
            entity.LocationTo = dto.LocationTo;
            entity.NoofPackages = dto.NoofPackages;
            entity.Weight = dto.Weight;
            entity.AmountRecieved = dto.AmountRecieved;
            entity.WayOfRecieve = dto.WayOfRecieve;
            entity.Fright = dto.Fright;
            entity.StCharges = dto.StCharges;
            entity.Hamali = dto.Hamali;
            entity.Other1 = dto.Other1;
            entity.Other2 = dto.Other2;
            entity.Other3 = dto.Other3;
            entity.Other4 = dto.Other4;
            entity.TotalAmount = dto.TotalAmount;
            entity.CreationDate = dto.CreationDate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="tblMRNote"/> to an instance of <see cref="tblMRNoteDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="tblMRNote"/> to convert.</param>
        public static tblMRNoteDTO ToDTO(this tblMRNote entity)
        {
            if (entity == null) return null;

            var dto = new tblMRNoteDTO();

            dto.MRId = entity.MRId;
            dto.MrNo = entity.MrNo;
            dto.BillId = entity.BillId ?? 0;
            dto.MRDate = entity.MRDate;
            dto.RecievedFrom = entity.RecievedFrom;
            dto.LocationFrom = entity.LocationFrom;
            dto.LocationTo = entity.LocationTo;
            dto.BillNo = entity.tblBill.BillNo;
            dto.BillDate = entity.tblBill.BillDate.Value.ToString("dd-MM-yyyy");
            dto.BillAmount = entity.tblBill.GrandTotal;
            dto.NoofPackages = entity.NoofPackages;
            dto.Weight = entity.Weight;
            dto.AmountRecieved = entity.AmountRecieved;
            dto.WayOfRecieve = entity.WayOfRecieve;
            dto.Fright = entity.Fright;
            dto.StCharges = entity.StCharges;
            dto.Hamali = entity.Hamali;
            dto.Other1 = entity.Other1;
            dto.Other2 = entity.Other2;
            dto.Other3 = entity.Other3;
            dto.Other4 = entity.Other4;
            dto.TotalAmount = entity.TotalAmount;
            dto.CreationDate = entity.CreationDate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="tblMRNoteDTO"/> to an instance of <see cref="tblMRNote"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tblMRNote> ToEntities(this IEnumerable<tblMRNoteDTO> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tblMRNote"/> to an instance of <see cref="tblMRNoteDTO"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<tblMRNoteDTO> ToDTOs(this IEnumerable<tblMRNote> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
