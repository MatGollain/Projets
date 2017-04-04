using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{

    public class Personnes
    {
        #region Propriétés
        public string CodePersonne { get; }
        public string Nom { get; }
        public string Prénom { get; }
        public CodeMétiers Métier { get; }
        #endregion

        #region Constructeurs
        public Personnes()
        {

        }
        public Personnes(string prenom, string nom, CodeMétiers métier)// Quand le constructeur est appellé il prend certains paramètres définis dans les propriètés 
        {
            CodePersonne = string.Format("{0}{1}", prenom[0], nom[0]); //on extrait les initiales du prénom et du nom pour en faire un "CodePersonne"
            Nom = nom;
            Prénom = prenom;
            Métier = métier;
        }
        #endregion

        #region Méthodes publiques
        public static Personnes TrouverNom(List<Personnes> data, string codePersonne)
        {
           
            foreach (var p in data)
            {
                if (p.CodePersonne == codePersonne)
                    return (new Personnes(p.Prénom, p.Nom, p.Métier));
            }
            return new Personnes();
            
        }


        //ici on remplit la liste<personnes> en créant de nouvelles personnes en appellant le constructeur qui prend les trois paramètres du nom, Prénom et code métier dans personne //on lui asssocie un métier grâce à l'enum CodeMétiers
        public static void RemplissagePersonne(List<Personnes> personnes)
        {
            personnes.Add(new Personnes("Geneviève", "Leclerq", CodeMétiers.ANA));
            personnes.Add(new Personnes("Angèle", "Ferrand", CodeMétiers.ANA));
            personnes.Add(new Personnes("Balthazar", "Normand", CodeMétiers.CDP));
            personnes.Add(new Personnes("Raymond", "Fisher", CodeMétiers.DEV));
            personnes.Add(new Personnes("Lucien", "Butler", CodeMétiers.DEV));
            personnes.Add(new Personnes("Roseline", "Beaumont", CodeMétiers.DEV));
            personnes.Add(new Personnes("Marguerite", "Weber", CodeMétiers.DES));
            personnes.Add(new Personnes("Hilaire", "Klein", CodeMétiers.TES));
            personnes.Add(new Personnes("Nino", "Palmer", CodeMétiers.TES));

        }
        #endregion
    }
}


