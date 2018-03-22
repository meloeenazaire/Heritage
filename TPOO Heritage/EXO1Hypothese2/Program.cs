using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exo1Hypothese2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammifère m1 = new Mammifère("Chien", "océan", "wouaf", true);
            Lion l1 = new Lion("Simba", "savane", "RRrr", false, 4);
            Chat c3 = new Chat("Felix", "rue", "miaou", true, 4);
            Baleine b1 = new Baleine("Mobidick", "océan", "hmmmm", false, 456, 400);

            m1.Afficher();
            l1.Afficher();
            c3.Afficher();
            b1.Afficher();
            Console.ReadLine();
        }
    }
}
