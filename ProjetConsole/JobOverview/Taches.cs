using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{
        public abstract class Taches //la classe est abstraite et on ne peut pas l'instancier. On pourra instancier seulement ses dérivés.//classe POCO
    {
        #region Propriétés
        public int NumTache { get; set; }
        public int DuréeTravailRéalisé { get; set; }
        public string LibTache { get; set; }
        #endregion
    }

    public class Production : Taches// Taches est l'ancêtre de production //classe POCO
    {
        #region Propriétés
        public string CodePersonne { get; set; }
        public CodeActivités ActivitéTache { get; set; }
        public DateTime DateDébutTravail { get; set; }
        public int DuréeTravailPrévu { get; set; }
        public int DuréeTravailRestant { get; set; }
        public string Version { get; set; }
        #endregion
    }
    public class Annexes : Taches// Tâches est l'ancêtre de annexe
    {

    }

}
