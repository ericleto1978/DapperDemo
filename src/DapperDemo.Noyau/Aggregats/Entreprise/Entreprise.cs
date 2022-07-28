using CleanArchitecture.Commun.Interfaces;
using CleanArchitecture.Commun;


namespace DapperDemo.Noyau.Aggregats.Entreprise
{
    public class Entreprise : EntiteBase, IAggregateRacine
    {
        public string Nom { get; set; }
        public int NIM { get; set; }

        public List<Participant> Participants { get; set; }

        public Entreprise()
        {
            Participants = new List<Participant>();
        }
        public Entreprise(string nom, int nim)
        {
            Nom = nom;
            NIM = nim;
            Participants = new List<Participant>();
        }
    }
}
