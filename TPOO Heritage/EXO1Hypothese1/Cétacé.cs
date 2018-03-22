using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXO1Hypothese1
{
    class Cétacé:Mammifère
    {
        protected int duréeApnée;
        protected int profondeurPlongée;

        public Cétacé(string nom, string lieuHabitation, string monCri, bool jeSuisDomestique, int duréeApnée, int profondeurPlongée)
            : base(nom, lieuHabitation, monCri, jeSuisDomestique)
        {
            this.nom = nom;
            this.lieuHabitation = lieuHabitation;
            this.monCri = monCri;
            this.jeSuisDomestique = jeSuisDomestique;
            this.duréeApnée = duréeApnée;
            this.profondeurPlongée = profondeurPlongée;

        }

        
    }
}
