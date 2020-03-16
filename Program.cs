using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pendu
{
    class Program
    {
        static void Main(string[] args)
        {

            string motATrouver = "coucou";
            string lettre = "b";
            int longeurMot;
            string[] mask;
            string joueur1;
            string joueur2;
            int essai = 0;
            bool gagner = false;
            bool trouve = motATrouver.Contains(lettre);
            Console.WriteLine("'{0}' is in the string '{1}': {2}",
                            lettre, motATrouver, trouve);

            string[] lettreTrouve;

            Console.WriteLine("Nom du joueur 1 ?");
            joueur1 = Console.ReadLine();


            Console.WriteLine("Nom du joueur 2 ?");
            joueur2 = Console.ReadLine();


            Console.WriteLine(joueur1 + " ,veuillez entre un mot à l'abri du regard de " + joueur2);
            motATrouver = Console.ReadLine();
            Console.Clear();
            int tailleMot = motATrouver.Length;

            string[] lettretrouve = new string[tailleMot];
            char[] motDecoupe = motATrouver.ToCharArray();
            Console.WriteLine(motDecoupe[3]);
            Console.WriteLine(joueur2 + " , proposer une et une seule lettre :");
            lettre = Console.ReadLine();


            while (essai < 5 && gagner == false)
            {

                for (int i = 0; i < motDecoupe.Length; i++)
                {

                    if (trouve)
                    {
                        Console.WriteLine(lettre);

                    }
                    else
                    {
                        Console.WriteLine("*");
                    }


                }

                Console.WriteLine(joueur2 + "Proposer une et une seule lettre");
                essai++;
                Console.ReadLine();
            }




        }
    }
}