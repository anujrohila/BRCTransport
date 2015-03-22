using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BRCTransport.Domain;
using System.ComponentModel.DataAnnotations;

namespace BRCTransport.Web
{
    public class ReportBillPartyWiseSearch
    {
        public int PartyId { get; set; }

        [Required]
        public string StartDate { get; set; }

        [Required]
        public string EndDate { get; set; }

        public bool IsSearchClick { get; set; }

        public List<tblConsignorDTO> PartyList { get; set; }
    }
}