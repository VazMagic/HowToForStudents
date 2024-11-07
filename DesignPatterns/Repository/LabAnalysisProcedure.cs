using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowTo.DesignPatterns.Repository
{
    public class LabAnalysisProcedure
    {
        public int LabAnalysisID { get; set; }
        public string RequestedAnalName { get; set; }
        public string ProcedName { get; set; }
        public string ProcedAbbrev { get; set; }
        public string ProcedDesc { get; set; }
        public int SSIR5Page { get; set; }
        public int PDFPage { get; set; }
        public string LinksToSSIR42V5 { get; set; }
        public string Notes { get; set; }
    }
}
