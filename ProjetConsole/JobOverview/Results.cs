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

        public int DuréeTotaleActivité(List<Production> data, CodeActivités act)//Calcul de la durée prévue totale par activité. On appelle en paramètre
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
        public int DuréeTravailAnnexe(List<Annexes>data, int mois, string nomtache)
        {
            return data.Where(p => p.DateAnnexe.Month == mois && p.LibTache==nomtache).Sum(dtr => dtr.DuréeTravailRéalisé);
        }


    }
}
