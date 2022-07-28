using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Commun;

namespace DapperDemo.Noyau.Aggregats.Entreprise
{
    public class Participant : EntiteBase
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int PourcentageParticipation { get; set; }


        public Participant()
        {

        }
        public Participant(string nom, string prenom, int pourcentage)
        {
            Nom = nom;
            Prenom = prenom;
            PourcentageParticipation = pourcentage;
        }
    }
}
