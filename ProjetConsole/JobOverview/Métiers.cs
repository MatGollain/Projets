using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{
    [Flags]
    public enum CodeActivités
    {
        Aucun = 0,
        DBE = 1,
        ARF = 2,
        ANF = 4,
        DES = 8,
        INF = 16,
        ART = 32,
        ANT = 64,
        DEV = 128,
        RPT = 256,
        TES = 512,
        GDP = 1024,
    }

    public enum CodeMétier {ANA,CDO,DEV,DES,TES }

        public class Métiers
    {
        public Dictionary<CodeMétier, string> Métier { get; set; }
    }

    public class Activités
    {
        public Dictionary<CodeActivités, string> Métier { get; set; }

    }
}
