using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{

    class Personnes
    {
        Dictionary<Métiers, Activités> _métier;

        #region Propriété
        public string CodePersonne { get; set; }
        public string Nom { get; set; }
        public string Prénom { get; set; }
        public Métiers Métier { get; private set; }
        #endregion

        #region Méthodes publiques

        public void RemplissagePersonne(List<Personnes> personnes)
        {

            personnes.Add(new Personnes("Genevièvre", "Leclerq", Métiers.ANA));
            personnes.Add(new Personnes("Angèle", "Ferrand", Métiers.ANA));
            personnes.Add(new Personnes("Balthazar", "Normand", Métiers.CDP));
            personnes.Add(new Personnes("Raymond", "Fisher", Métiers.DEV));
            personnes.Add(new Personnes("Lucien", "Butler", Métiers.DEV));
            personnes.Add(new Personnes("Roseline", "Beaumont", Métiers.DEV));
            personnes.Add(new Personnes("Marguerite", "Weber", Métiers.DES));
            personnes.Add(new Personnes("Hilaire", "Klein", Métiers.TES));
            personnes.Add(new Personnes("Nino", "Palmer", Métiers.TES));

           
        }
    }
}
