using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo1Hypothese2
{
    class Mammifère
    {
        private string nom;
        private string lieuHabitation;
        private string monCri;
        private bool jeSuisDomestique;
        private bool dangereux;

        public Mammifère(string nom, string lieuHabitation, string monCri, bool jeSuisDomestique)
        {
            this.nom = nom;
            this.lieuHabitation = lieuHabitation;
            this.monCri = monCri;
            this.jeSuisDomestique = jeSuisDomestique;
        }

        public void Afficher()
        {
            Console.WriteLine("Nom : {0}\nLieu d'habitation : {1}\nCri : {2}\nDomestique ? {3}", nom, lieuHabitation, monCri, jeSuisDomestique);
        }

        public bool JeSuisDangereux()
        {
            return dangereux;
        }
    }
}
