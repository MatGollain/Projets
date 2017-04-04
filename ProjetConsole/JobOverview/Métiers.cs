using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{
    [Flags]
    public enum CodeActivités
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

    public enum CodeMétiers {ANA,CDP,DEV,DES,TES }

        public class Métiers
    {
        public Dictionary<CodeMétiers, string> Métier { get; set; }

        public void RemplissageMétier(Dictionary<CodeMétiers, string> métiers)
        {
            métiers.Add(CodeMétiers.ANA, "Analyste");
            métiers.Add(CodeMétiers.CDP, "Chef de projet");
            métiers.Add(CodeMétiers.DEV, "Développeur");
            métiers.Add(CodeMétiers.DES, "Designer");
            métiers.Add(CodeMétiers.TES, "Testeur");
        }
    }

    public class Activités
    {
        public Dictionary<CodeActivités, string> Activité { get; set; }

        public void RemplissageActivité(Dictionary<CodeActivités, string> activités)
        {
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
    }
}



