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

        public static void AfficherTravailPersonne(List<Production> data, List<Personnes> personnes)
        {
            string saisiea, saisieb;
            int travReal, travRest;
            Console.WriteLine("Quelle est la version de logiciel sur laquelle vous voulez avoir une information, 1.00 ou 2.00?");
            saisiea = Console.ReadLine();
            Console.WriteLine("Pour quelle personne voulez-vous avoir une information? initiale");
            saisieb = Console.ReadLine();
            Personnes p = Personnes.TrouverNom(personnes, saisiea);
            travReal = Results.DuréeTravailRéaliséPersonne(data, saisieb, saisiea);
            travRest = Results.DuréeTravailRestantPersonne(data, saisieb, saisiea);
            Console.WriteLine("Sur la version {0}, {1} {2} a réalisé {3} jours de travail, et il lui reste {4} jours de planifiés.", saisiea, p.Nom, p.Prénom, travReal, travRest);
        }

        public static void AfficherTravailActivité(List<Production> data, Activités activités)
        {
            string saisiea, saisiec, act;
            int dureeAct;
            Console.WriteLine("Quelle est la version de logiciel sur laquelle vous voulez avoir une information, 1.00 ou 2.00?");
            saisiea = Console.ReadLine();
            Console.WriteLine("Pour quelle activité voulez-vous avoir une information? code d'activité");
            saisiec = Console.ReadLine();
            CodeActivités saisiecprim = (CodeActivités)Enum.Parse(typeof(CodeActivités), saisiec);
            dureeAct = Results.DuréeTotaleActivité(data, saisiecprim);
            act = activités.TrouverActivité(saisiecprim);
            Console.WriteLine("La durée de travail réalisée pour l'activité {0} sur la version {1} est de {2}", act, saisiea, dureeAct);
        }

        public static void AfficherPourcentage(List<Production> data)
        {
            string saisiea;
            int travReal, travPrev, diff, pourcen;
            Console.WriteLine("Quelle est la version de logiciel sur laquelle vous voulez avoir une information, 1.00 ou 2.00?");
            saisiea = Console.ReadLine();
            travReal = Results.DuréeTravailRéaliséVersion(data, saisiea);
            travPrev = Results.DuréeTravailPrévuVersion(data, saisiea);
            diff = travPrev - travReal;
            pourcen = (diff / travPrev) * 100;
            if (diff < 0)
                Console.WriteLine("Sur la version {0}, la durée de travail réalisée a dépassé de {1} la durée prévue, ce qui représente un pourcentage de retard proche de {2}", saisiea, diff * -1, pourcen);
            else if (diff > 0)
                Console.WriteLine("Sur la version {0}, la durée de travail réalisée est inférieur de {1} la durée prévue, ce qui représente un pourcentage d'avance proche de {2}", saisiea, diff * -1, pourcen);
            else
                Console.WriteLine("Sur la version {0}, la durée de travail réalisée est égale à la durée prévue", saisiea);

        }

    }
}
