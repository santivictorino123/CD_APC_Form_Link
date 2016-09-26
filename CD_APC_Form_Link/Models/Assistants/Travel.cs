using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CD_APC_Form_Link.Models.Assistants
{
    public class Travel
    {
        public int DepartureCountry { get; set; }
        public DateTime DepartureDate { get; set; }
        public int DestinationCountry { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}