using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXO1Hypothese1
{
    class Baleine:Cétacé
    {
        public Baleine(string nom, string lieuHabitation, string monCri, bool jeSuisDomestique, int duréeApnée, int profondeurPlongée)
            : base(nom, lieuHabitation, monCri, jeSuisDomestique,duréeApnée,profondeurPlongée)
        {
            this.nom = nom;
            this.lieuHabitation = lieuHabitation;
            this.monCri = monCri;
            this.jeSuisDomestique = jeSuisDomestique;
            this.duréeApnée = duréeApnée;
            this.profondeurPlongée = profondeurPlongée;

        }

        public new bool JeSuisDangereux()
        {
            base.JeSuisDangereux();
            dangereux = false;
            Console.WriteLine("{0} est-il dangereux ? " +dangereux,nom);
            return dangereux;
        }

        public void Afficher()
        {
            Console.WriteLine("Nom : {0}\nLieu d'habitation : {1}\nCri : {2}\nDomestique ? {3}\nDurée d'apnée : {4}\nProfondeur de plongée : {5}\n", nom, lieuHabitation, monCri, jeSuisDomestique, duréeApnée, profondeurPlongée);
        }
    }
}
