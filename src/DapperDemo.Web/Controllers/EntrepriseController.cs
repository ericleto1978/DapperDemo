using DapperDemo.Noyau.Aggregats.Entreprise;
using DapperDemo.Noyau.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DapperDemo.Web.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]/[action]")]


    public class EntrepriseController : ControllerBase
    {
        private readonly IEntrepriseRepository entrepriseRepo;

        public EntrepriseController(IEntrepriseRepository repository)
        {
            entrepriseRepo = repository;
        }

        [HttpGet]
        [ActionName("ObtenirLesEntreprises")]
        public List<Entreprise> ObtenirLesEntreprises()
        {
            return entrepriseRepo.ObtenirLesEntreprises();
        }
    }
}
