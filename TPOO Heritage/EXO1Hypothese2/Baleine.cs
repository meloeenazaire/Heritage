using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo1Hypothese2
{
    class Baleine : Cétacé
    {
        public Baleine(string nom, string lieuHabitation, string monCri, bool jeSuisDomestique, int duréeApnée, int profondeurPlongée)
            : base(nom, lieuHabitation, monCri, jeSuisDomestique, duréeApnée, profondeurPlongée)
        {
        }

        public new void Afficher()
        {
            base.Afficher();
        }
    }
}
