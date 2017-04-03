using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JobOverview
{
    [Flags]
    public enum Activités
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
    public enum Métiers { ANA, CDP, DEV, DES, TES }

    class DAL
    {
        #region Propriétés
        public List<Taches> Data { get; }
        #endregion

        #region Constructeurs
        public DAL()
        {
            var b = new List<Taches>();
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
                    try
                    {
                        var taches = new Production
                        {
                            NumTache = int.Parse(tab[0]),
                            Version = double.Parse(tab[1]),
                            LibTache = (tab[4]),
                            DateDébutTravail = DateTime.Parse(tab[5]),
                            DuréeTravailPrévu = double.Parse(tab[6]),
                            DuréeTravailRéalisé = double.Parse(tab[7]),
                            DuréeTravailRestant = double.Parse(tab[8]),
                        };

                        Data.Add(taches);// Ajout des données à la liste
                    }
                    catch (FormatException)
                    {

                        Console.WriteLine("Erreur de format à la ligne suivante :\r\n{0}", ligne);// On ignore la ligne
                    }

                }
            }
        }
        #endregion
    }
}
