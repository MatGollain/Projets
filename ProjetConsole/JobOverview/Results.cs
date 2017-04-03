using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{
    class Results
    {

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

        public void AfficherRésultats(List<Taches> data)
        {
            var res1 = data.Where(a => a.Activité).Sum(dtp => dtp.DuréeTravailPrévu);//durée totale prévue d'une activité
            var res2 = data.Where(p => p.Personnes).Sum(dtr => dtr.DuréeTravailRéalisé);//durée de travail réalisé d'une personne
            var res3 = data.Where(p => p.Personnes).Sum(dtres => dtres.DuréeTravailRestant);//durée de travail restant d'une personne

        }
    }
}
