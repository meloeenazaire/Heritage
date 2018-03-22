using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXO1Hypothese1
{
    class Program
    {
        static void Main(string[] args)
        {
            //COLLECTIONSS
            List<Chat> lesChats = new List<Chat>();
            List<Lion> lesLions = new List<Lion>();
            List<Baleine> lesBaleines = new List<Baleine>();

            //INSTANCIATIONS
            Mammifère m1 = new Mammifère("Dauphin", "océan", "hihi", true);
            Félin f1 = new Félin("Panthère", "savane", "roar", false, 4);
            Lion l1 = new Lion("Simba", "savane", "RRrr", false, 4);
            Lion l2 = new Lion("Mufasa", "savane", "RRrr", false, 4);
            Lion l3 = new Lion("Scar", "savane", "RRrr", false, 4);
            Chat c1 = new Chat("Potté", "forêt", "miaou", true, 4);
            Chat c2 = new Chat("Minou", "maison", "miaou", true, 4);
            Chat c3 = new Chat("Felix", "rue", "miaou", true, 4);
            Cétacé ce1 = new Cétacé("Orque", "océan", " ", false, 50, 400);
            Baleine b1 = new Baleine("Mobidick", "océan", "hmmmm", false, 456, 400);

            //AFFICHAGE
            lesChats.Add(c1);
            lesChats.Add(c2);
            lesChats.Add(c3);
            lesLions.Add(l1);
            lesLions.Add(l2);
            lesLions.Add(l3);
            lesBaleines.Add(b1);

            
            l1.Afficher();
            //l1.JeSuisDangereux();
            c1.Afficher();
            //c1.JeSuisDangereux();
            b1.Afficher();
            //b1.JeSuisDangereux();         
                    
            
            //LE CLIENT CHOSISI SON ANIMAL EN FONCTION DE SA DANGEROSITE
            Console.WriteLine("Quel animal souhaitez-vous adopter ?\n");
            int choix;
            Console.WriteLine("1 - Félin");
            Console.WriteLine("2 - Cétacé");
            Console.WriteLine("Votre choix: ");
            choix = Convert.ToInt32(Console.ReadLine());

            switch (choix)
            {
                case 1:
                    int choix2;
                    Console.WriteLine("\n1 - un Chat?");
                    Console.WriteLine("\n2 - ou un Lion?");
                    choix2 = Convert.ToInt32(Console.ReadLine());

                    switch (choix2)
                    {
                        case 1:
                            Console.WriteLine("Vous pouvez adopter un chat, ce n'est pas dangereux!\n");
                            break;

                        case 2:
                            Console.WriteLine("vous ne pouvez pas adopter un lion, c'est trop dangereux!\n");
                            break;

                        default:
                            break;
                    }

                    break;

                case 2:
                    int choix3;
                    Console.WriteLine("\n1 - une Baleine?");
                    choix3 = Convert.ToInt32(Console.ReadLine());

                    switch (choix3)
                    {
                        case 1:
                            Console.WriteLine("Vous pouvez adopter une baleine!");
                           break;
                        default:
                           break;
                    }
                    break;

                default:
                    break;

            }

            Console.ReadLine();
        }
    }
}
