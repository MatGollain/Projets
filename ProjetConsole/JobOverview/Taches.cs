using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{
    public class Taches
    {
        #region Proriété

        public int NumTache { get; set; }
        public double DuréeTravailRéalisé { get; set; }
        public string LibTache { get; set; }

        #endregion
    }

    public class Production : Taches
    {
        #region Propriété

        public DateTime DateDébutTravail { get; set; }
        public double DuréeTravailPrévu { get; set; }
        public double DuréeTravailRestant { get; set; }
        public double Version { get; set; }

        #endregion
    }

}
