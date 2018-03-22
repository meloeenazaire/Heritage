using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo3
{
    class Véhicule
    {
        protected string immatriculation;
        protected int anneeConstruction;
        protected string marque;
        protected string modele;

        protected Véhicule(string immatriculation, int anneeConstruction, string marque, string modele)
        {
            this.immatriculation = immatriculation;
            this.anneeConstruction = anneeConstruction;
            this.marque = marque;
            this.modele = modele;
        }

        public string ToString()
        {
            return string.Format(" Immatriculation: {0}\n Année de Construction: {1}\n Marque: {2}\n Modèle: {3}\n",immatriculation, anneeConstruction, marque, modele);
        }
    }
}
