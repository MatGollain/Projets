using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JobOverview
{

    class DAL
    {
        #region Propriétés
        public List<Taches> Data { get; }
        #endregion

        #region Constructeurs
        public DAL()
        {
            Data = new List<Taches>();
        }
        #endregion

        #region Méthodes Publiques
        public void ChargeFichier()
        {
            string chemin = @"..\..\ProjetJobOverview.txt";

            int cpt = 0;
            using (StreamReader str = new StreamReader(chemin))
            {
                string ligne;

                while ((ligne = str.ReadLine()) != null)
                {
                    cpt++;
                    if (cpt == 1) continue; // On ne charge pas les entêtes

                    var tab = ligne.Split('\t');

                    var taches = new Production
                    {
                        NumTache = int.Parse(tab[0]),
                        Version = tab[1],
                        CodePersonne = tab[2],                      
                        ActivitéTache = (CodeActivités)Enum.Parse(typeof(CodeActivités), tab[3]),  
                        LibTache = tab[4],
                        DateDébutTravail = DateTime.Parse(tab[5]),
                        DuréeTravailPrévu = int.Parse(tab[6]),
                        DuréeTravailRéalisé = int.Parse(tab[7]),
                        DuréeTravailRestant = int.Parse(tab[8]),
                    };

                    Data.Add(taches);// Ajout des données à la liste
                                        
                }
            }
        }
        #endregion
    }
    
}
