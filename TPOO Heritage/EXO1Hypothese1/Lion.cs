using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXO1Hypothese1
{
    class Lion:Félin
    {
        public Lion(string nom, string lieuHabitation, string monCri, bool jeSuisDomestique, int nombresPattes)
            : base(nom, lieuHabitation, monCri, jeSuisDomestique,nombresPattes)
        {
            this.nom = nom;
            this.lieuHabitation = lieuHabitation;
            this.monCri = monCri;
            this.jeSuisDomestique = jeSuisDomestique;
            this.nombresPattes = nombresPattes;

        }

        public new bool JeSuisDangereux()
        {
            base.JeSuisDangereux();
            dangereux = true;
            Console.WriteLine("{0} est-il dangereux ? " + dangereux, nom);
            return dangereux;
        }


        public void Afficher()
        {
            Console.WriteLine("Nom : {0}\nLieu d'habitation : {1}\nCri : {2}\nDomestique ? {3}\nNombres de Pattes : {4}\n", nom, lieuHabitation, monCri, jeSuisDomestique, nombresPattes);
        }
        

    }
}
