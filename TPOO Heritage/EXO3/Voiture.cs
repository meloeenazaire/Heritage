using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo3
{
    class Voiture:Véhicule
    {
        protected bool decapotable;
        protected bool climatisation;

        public Voiture(string immatriculation, int anneeConstruction, string marque, string modele, bool decapotable, bool climatisation):base(immatriculation,anneeConstruction,marque,modele)
        {
            this.immatriculation = immatriculation;
            this.anneeConstruction = anneeConstruction;
            this.marque = marque;
            this.modele = modele;
            this.decapotable = decapotable;
            this.climatisation = climatisation;
        }

        public bool estDecapotable()
        {
            if (decapotable==true)
            {
                Console.Write(" Voiture décapotable");
            }
            else
            {
                Console.Write(" Voiture Non décapotable");
            }
            return decapotable;
        }

        public bool avecClimatisation()
        {
            if (climatisation == true)
            {
                Console.WriteLine(" avec climatisation");
            }
            else
            {
                Console.WriteLine(" sans climatisation");
            }

            return climatisation;
        }

        public new string ToString()
        {
            base.ToString();
            return string.Format("{0} {1}\n Immatriculation: {2}\n Année de Construction: {3}\n Marque: {4}\n Modèle: {5}\n ", estDecapotable(), avecClimatisation(), immatriculation, anneeConstruction, marque, modele);
        }
    }
}
