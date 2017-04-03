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

    }
}
