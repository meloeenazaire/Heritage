using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo3
{
    class Camion:Véhicule
    {
        
        protected bool semiRemorque;
        protected int essieux;

        public Camion(string immatriculation,int anneeConstruction,string marque,string modele, bool semiRemorque, int essieux):base(immatriculation,anneeConstruction,marque,modele)
        {
            this.immatriculation = immatriculation;
            this.anneeConstruction = anneeConstruction;
            this.marque = marque;
            this.modele = modele;
            this.semiRemorque = semiRemorque;
            this.essieux = essieux;
        }

        public bool SemiRemorque()
        {
            if (semiRemorque==true)
            {
                Console.Write(" Camion Semi-remorque");
            }
            else
            {
                Console.Write(" Camion Non semi-remorque");
            }
            return semiRemorque;
        }

        public int NbrEssieux()
        {
            Console.WriteLine("avec {0} essieux", essieux);
            return essieux;
        }

        public new string ToString()
        {
            base.ToString();
            return string.Format("{0}{1} \n Immatriculation: {2}\n Année de Construction: {3}\n Marque: {4}\n Modèle: {5}\n ", SemiRemorque(), NbrEssieux(), immatriculation, anneeConstruction, marque, modele, semiRemorque);
        }
    }
}
