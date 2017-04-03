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
        public string CodePersonne { get; }
        public string Nom { get; }
        public string Prénom { get; }
        public CodeMétiers Métier { get; }
        #endregion
        #region Constructeur

        public Personnes()
        {

        }


        public Personnes(string prenom, string nom, CodeMétiers métier)
        {
            CodePersonne = string.Format("{0}{1}", prenom[0], nom[0]);
            Nom = nom;
            Prénom = prenom;
            Métier = métier;
        }

        #endregion
        #region Méthodes publiques

        public static Personnes TrouverNom(List<Personnes> data, string codePersonne)
        {
            //var per = data.Where(p => p.CodePersonne == codePersonne);

            foreach (var p in data)
            {
                if (p.CodePersonne == codePersonne)
                    return (new Personnes(p.Prénom,p.Nom,p.Métier));
            }
            return new Personnes();

        }
        #endregion
    }
}
