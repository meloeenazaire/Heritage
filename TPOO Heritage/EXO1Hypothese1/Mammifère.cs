using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXO1Hypothese1
{
    class Mammifère
    {
        protected string nom;
        protected string lieuHabitation;
        protected string monCri;
        protected bool jeSuisDomestique;
        protected bool dangereux;

        public Mammifère(string nom, string lieuHabitation, string monCri, bool jeSuisDomestique)
        {
            this.nom = nom;
            this.lieuHabitation = lieuHabitation;
            this.monCri = monCri;
            this.jeSuisDomestique = jeSuisDomestique;
        }

        public bool JeSuisDangereux()
        {            
            return dangereux;
        }


    }
}
