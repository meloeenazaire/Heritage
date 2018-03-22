using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo3
{
    class Program
    {
        static void Main(string[] args)
        {

            //INSTANCIATION

            Véhicule[] Tab = new Véhicule[4];

            Tab[0] = new Voiture("333 ABC 06",2000,"Peugeot","306",true,false);
                
            Tab[1] = new Voiture("321 BBD 06",2001,"Renault","Clio",false,true);

            Tab[2] = new Camion("1234 TZ 06",1993,"DAF","T43",true,4);

            Tab[3] = new Camion("765 ACE 06",1999,"Mercedes","C.L",false,3);

            //BOUCLE D'AFFICHAGE
            
            for (int i=0; i<Tab.Length; i++)
            {
                if (Tab[i] is Voiture)
                {
                    ((Voiture)Tab[i]).estDecapotable();
                    ((Voiture)Tab[i]).avecClimatisation();
                }
                
                if (Tab[i] is Camion)
                {
                    ((Camion)Tab[i]).SemiRemorque();
                    ((Camion)Tab[i]).NbrEssieux();
                }
                Console.WriteLine(Tab[i].ToString());
            }

            Console.ReadLine();
        }
    }
}
