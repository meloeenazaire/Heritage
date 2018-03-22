using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo1Hypothese2
{
    class Félin : Mammifère
    {
        private int nombresPattes;

        public Félin(string nom, string lieuHabitation, string monCri, bool jeSuisDomestique, int nombresPattes)
            : base(nom, lieuHabitation, monCri, jeSuisDomestique)
        {
            this.nombresPattes = nombresPattes;

        }

        public new void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Nombre de Pattes : {0}\n", nombresPattes);
        }
    }
}
