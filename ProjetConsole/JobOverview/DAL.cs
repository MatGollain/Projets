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
        public List<Production> Data { get; }
        #endregion

        #region Constructeurs
        public DAL()
        {
            Data = new List<Production>();//Ce constructeur instancie une nouvelle liste
        }
        #endregion

        #region Méthodes Publiques
        public void ChargeFichier()
        {
            string chemin = @"..\..\ProjetJobOverview.txt";

            int cpt = 0;
            using (StreamReader str = new StreamReader(chemin))//on lit la ligne
            {
                string ligne; //on crée une variable ligne de type string

                while ((ligne = str.ReadLine()) != null)//tant qu'il reste des lignes à lire
                {
                    cpt++;//on incrémente le compteur
                    if (cpt == 1) continue; // Si mon compteur est égale à 1, on ne charge pas les entêtes et on repart au while

                    var tab = ligne.Split('\t');// on fait une tabulation après avoir charger chaque ligne

                    var taches = new Production//on affecte chaque colonne à une valeur et on convertit dans le type qui convient si besoin
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
