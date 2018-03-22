using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo1Hypothese2
{
    class Cétacé:Mammifère
    {
        private int duréeApnée;
        private int profondeurPlongée;

        public Cétacé(string nom, string lieuHabitation, string monCri, bool jeSuisDomestique, int duréeApnée, int profondeurPlongée)
            : base(nom, lieuHabitation, monCri, jeSuisDomestique)
        {
            this.duréeApnée = duréeApnée;
            this.profondeurPlongée = profondeurPlongée;

        }

        public new void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Durée d'apnée : {0}\nProfondeur de plongée : {1}\n", duréeApnée, profondeurPlongée);
        }
    }
}
