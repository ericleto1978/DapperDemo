using DapperDemo.Noyau.Aggregats.Entreprise;

namespace DapperDemo.Noyau.Interfaces
{
    public interface IEntrepriseRepository
    {
        public List<Entreprise> ObtenirLesEntreprises();
    }
}
