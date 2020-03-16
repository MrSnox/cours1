using System;
using System.Collections.Generic;
using System.Text;

namespace cours1.Entities
{
    public class Personne
    {
        public Personne()
        {

        }
        public Personne(string pnom)
        {
            nom = pnom;
        }
        public Personne(string pnom, string prenom)
        {
            nom = pnom;

        }
        private string nom;

        public string Nom
        {
            get { return nom; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    return;
                }
                nom = value;
            }
        }


    }
}
