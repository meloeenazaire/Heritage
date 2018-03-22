using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXO1Hypothese1
{
    class Félin:Mammifère
    {
        protected int nombresPattes;

        public Félin(string nom, string lieuHabitation, string monCri, bool jeSuisDomestique, int nombresPattes):base(nom,lieuHabitation,monCri,jeSuisDomestique)
        {
            this.nom = nom;
            this.lieuHabitation = lieuHabitation;
            this.monCri = monCri;
            this.jeSuisDomestique = jeSuisDomestique;
            this.nombresPattes = nombresPattes;

        }

        
    }
}
