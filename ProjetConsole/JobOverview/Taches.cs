using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{
    public class Taches
    {
        #region Proriétés

        public int NumTache { get; set; }
        public double DuréeTravailRéalisé { get; set; }
        public string LibTache { get; set; }

        #endregion
    }

    public class Production : Taches
    {
        #region Propriétés

        public DateTime DateDébutTravail { get; set; }
        public double DuréeTravailPrévu { get; set; }
        public double DuréeTravailRestant { get; set; }
        public double Version { get; set; }

        #endregion
    }
    public class Annexes : Taches
    {

    }

}
