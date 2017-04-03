using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{
    class Results
    {


        public void CalculerTravailRéalisé(List<Taches> p)
        {

        }
        // méthodes de calcules / affichage? 
        /*
        CalculerTempsTotal
            => Surcharge en fonction du besoin / personne / version / métier etc
        CalculerTempsActivité
        CalculerTempsMétierRéalisé
        CalculerTempsMétierRestant
        CalculerTempsMétierTotal
        CalculerTempsPersonneRéalisé
        CalculerTempsPersonneRestant
        CalculerTempsPersonneTotal
        */

        public int DuréeTotaleActivité(List<Production> data, CodeActivités act)
        {
            var preAct = data.Where(a => a.ActivitéTache == act).Sum(dtp => dtp.DuréeTravailPrévu);
            return preAct;
        }

        public int DuréeTravailRéaliséPersonne(List<Production> data, string codper, string ver)
        {
            return data.Where(p => p.CodePersonne == codper && p.Version == ver).Sum(dtr => dtr.DuréeTravailRéalisé);
        }

        public int DuréeTravailRestantPersonne(List<Production> data, string codper, string ver)
        {
            return data.Where(p => p.CodePersonne == codper && p.Version == ver).Sum(dtres => dtres.DuréeTravailRestant);
        }



}
}
