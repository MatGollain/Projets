using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOverview
{
   public class Versions//classe POCO
    {
        public double Numero { get; set; }
        public int Millésime { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DatePubli { get; set; }

    }
}
