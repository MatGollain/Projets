using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{
    [Flags]
    public enum CodeActivités//on crée une enum "Flags" car une métier peut avoir plusieurs activités
    {
        Aucun = 0,
        DBE = 1,
        ARF = 2,
        ANF = 4,
        DES = 8,
        INF = 16,
        ART = 32,
        ANT = 64,
        DEV = 128,
        RPT = 256,
        TES = 512,
        GDP = 1024,
    }

    public enum CodeMétiers { ANA, CDP, DEV, DES, TES }//on crée une enum "normal" car une personne ne peut avoir qu'un seul métier

    public class Métiers
    {
        #region Propriétés
        public Dictionary<CodeMétiers, string> Métier { get; set; }
        #endregion

        #region Constructeur
        public Métiers()
        {
            Métier = new Dictionary<CodeMétiers, string>();
        }
    
        #endregion

        #region Méthodes publiques     
        public void RemplissageMétier()//cette méthode prend comme paramètre le dictionnaire définit dans les propriétés 
        {//on remplit un dictionnaire qui définit les "CodeMétier". On peut le faire car on a instancié ?????relation avec l'appel du constructeur
            Métier.Add(CodeMétiers.ANA, "Analyste");
            Métier.Add(CodeMétiers.CDP, "Chef de projet");
            Métier.Add(CodeMétiers.DEV, "Développeur");
            Métier.Add(CodeMétiers.DES, "Designer");
            Métier.Add(CodeMétiers.TES, "Testeur");
        }
        #endregion
    }

    public class Activités
    {
        #region Propriétés
        public Dictionary<CodeActivités, string> Activité { get; set; }
        #endregion

        #region Constructeur
        public Activités()
        {
            Activité = new Dictionary<CodeActivités, string>();
        }
        #endregion



        #region Méthodes Publiques
        public void RemplissageActivité()//cette méthode prend comme paramètre le dictionnaire définit dans les propriétés
        {//on remplit un dictionnaire qui définit les "CodeActivités". On peut le faire car on a instancié ?????relation avec l'appel du constructeur
            Activité.Add(CodeActivités.DBE, "Définition de besoins");
            Activité.Add(CodeActivités.ARF, "Architecture fonctionnelle");
            Activité.Add(CodeActivités.ANF, "Analyse fonctionnelle");
            Activité.Add(CodeActivités.DES, "Design");
            Activité.Add(CodeActivités.INF, "Infographie");
            Activité.Add(CodeActivités.ART, "Architecture technique");
            Activité.Add(CodeActivités.ANT, "Analyse technique");
            Activité.Add(CodeActivités.DEV, "Développement");
            Activité.Add(CodeActivités.RPT, "Rédaction de plan de test");
            Activité.Add(CodeActivités.TES, "Test");
            Activité.Add(CodeActivités.GDP, "Gestion de projet");

            // activités.Activité(new Dictionary<CodeActivités, string> (CodeActivités.DBE, "Définition de besoins"));
        }
        public string TrouverActivité (CodeActivités ca)
        {
            foreach(var m in Activité)
            {
                if (m.Key == ca)
                    return (m.Value);
            }
            return string.Empty;
        }
         #endregion
    }
}



