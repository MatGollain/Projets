using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{
    public static class Results
    {


        public static int DuréeTotaleActivité(List<Production> data, CodeActivités act)//Calcul de la durée prévue totale par activité. On appelle en paramètre
        {
            var preAct = data.Where(a => a.ActivitéTache == act).Sum(dtp => dtp.DuréeTravailPrévu);
            return preAct;
        }

        public static int DuréeTravailRéaliséPersonne(List<Production> data, string codper, string ver)
        {
            return data.Where(p => p.CodePersonne == codper && p.Version == ver).Sum(dtr => dtr.DuréeTravailRéalisé);
        }

        public static int DuréeTravailPrévuPersonne(List<Production> data, string codper, string ver)
        {
            return data.Where(p => p.CodePersonne == codper && p.Version == ver).Sum(dtp => dtp.DuréeTravailPrévu);
        }

        public static int DuréeTravailRestantPersonne(List<Production> data, string codper, string ver)
        {
            return data.Where(p => p.CodePersonne == codper && p.Version == ver).Sum(dtres => dtres.DuréeTravailRestant);
        }
        public static int DuréeTravailAnnexe(List<Annexes> data, int mois, string nomtache)
        {
            return data.Where(p => p.DateAnnexe.Month == mois && p.LibTache == nomtache).Sum(dtr => dtr.DuréeTravailRéalisé);
        }
        public static int DuréeTravailPrévuVersion(List<Production> data, string ver)
        {
            return data.Where(p => p.Version == ver).Sum(dtp => dtp.DuréeTravailPrévu);
        }
        public static int DuréeTravailRéaliséVersion(List<Production> data, string ver)
        {
            return data.Where(p => p.Version == ver).Sum(dtr => dtr.DuréeTravailRéalisé);
        }

    }
}
