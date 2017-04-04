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

        #region Méthodes publiques     
        public void RemplissageMétier(Dictionary<CodeMétiers, string> métiers)//cette méthode prend comme paramètre le dictionnaire définit dans les propriétés 
        {//on remplit un dictionnaire qui définit les "CodeMétier". On peut le faire car on a instancié ?????relation avec l'appel du constructeur
            métiers.Add(CodeMétiers.ANA, "Analyste");
            métiers.Add(CodeMétiers.CDP, "Chef de projet");
            métiers.Add(CodeMétiers.DEV, "Développeur");
            métiers.Add(CodeMétiers.DES, "Designer");
            métiers.Add(CodeMétiers.TES, "Testeur");
        }
        #endregion
    }

    public class Activités
    {
        #region Propriétés
        public Dictionary<CodeActivités, string> Activité { get; set; }
        #endregion

        #region Méthodes Publiques
        public void RemplissageActivité(Dictionary<CodeActivités, string> activités)//cette méthode prend comme paramètre le dictionnaire définit dans les propriétés
        {//on remplit un dictionnaire qui définit les "CodeActivités". On peut le faire car on a instancié ?????relation avec l'appel du constructeur
            activités.Add(CodeActivités.DBE, "Définition de besoins");
            activités.Add(CodeActivités.ARF, "Architecture fonctionnelle");
            activités.Add(CodeActivités.ANF, "Analyse fonctionnelle");
            activités.Add(CodeActivités.DES, "Design");
            activités.Add(CodeActivités.INF, "Infographie");
            activités.Add(CodeActivités.ART, "Architecture technique");
            activités.Add(CodeActivités.ANT, "Analyse technique");
            activités.Add(CodeActivités.DEV, "Développement");
            activités.Add(CodeActivités.RPT, "Rédaction de plan de test");
            activités.Add(CodeActivités.TES, "Test");
            activités.Add(CodeActivités.GDP, "Gestion de projet");

            // activités.Activité(new Dictionary<CodeActivités, string> (CodeActivités.DBE, "Définition de besoins"));
        }
        #endregion
    }
}



