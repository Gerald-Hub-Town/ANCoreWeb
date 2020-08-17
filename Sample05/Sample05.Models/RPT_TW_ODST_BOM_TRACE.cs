using System;
using System.Collections.Generic;
using System.Text;

namespace Sample05.Sample05.Models
{
    public class RPT_TW_ODST_BOM_TRACE
    {
        public string UNITID { get; set; }
        public string MATERIALLOTID { get; set; }
        public string VENDORNAME { get; set; }
        public string MATERIALNO { get; set; }
        public string MATERIALDESC { get; set; }
        public string DATECODE { get; set; }
        public string LOTCODE { get; set; }
        public string TWODBARCODE { get; set; }
        public string STEPID { get; set; }
        public int? STEPSEQ { get; set; }
        public string REFERENCE { get; set; }
        public int? CONSUMEDQTY { get; set; }
        public string CONSUMEDTIME { get; set; }
        public string MESSYSTEM { get; set; }
        public string LOTID { get; set; }

        public string EQPID { get; set; }

        public string LOTTRACEREF { get; set; }

        public string WORKORDER { get; set; }
        public DateTime? CONSUMEDTIME2 { get; set; }

        public string EXPIREDATE { get; set; }

        public string PANELID { get; set; }

    }
}
