using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{

    class Personnes
    {

        #region Propriété
        public string CodePersonne { get; set; }
        public string Nom { get; set; }
        public string Prénom { get; set; }
        public Métiers Métier { get; private set; }
        #endregion

        #region Constructeur

        public Personnes(string nom, string prenom, Métiers métier)
        {
            CodePersonne = string.Format("{0}{1}", prenom[0], nom[0]);
            Nom = nom;
            Prénom = prenom;
            Métier = métier;
        }        

        #endregion

    }
}
