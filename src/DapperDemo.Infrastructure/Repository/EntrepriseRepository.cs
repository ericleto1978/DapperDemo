using Dapper;
using DapperDemo.Noyau.Aggregats.Entreprise;
using DapperDemo.Noyau.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo.Infrastructure.Repository
{
    internal class EntrepriseRepository : IEntrepriseRepository
    {
        private readonly string connexionString;

        public EntrepriseRepository(IConfiguration configuration)
        {
            this.connexionString = configuration.GetConnectionString("ConnexionBDDapper");
        }

        public List<Entreprise> ObtenirLesEntreprises()
        {
            string SQL = @"SELECT ENT.ID as 'Id', ENT.NOM as 'Nom', ENT.NIM AS 'NIM', PART.ID as 'Id', PART.PRENOM as 'Prenom', PART.NOM as 'Nom', RELA.PourcentageParticipation as 'PourcentageParticipation'
                            FROM Entreprise ENT
                            LEFT JOIN Rela_Entreprise_Participant RELA ON RELA.IdEntreprise = ENT.Id
                            LEFT JOIN Participant PART ON PART.ID = RELA.IdParticipant";

            using var con = new SqlConnection(connexionString);
            con.Open();

            var entreprises = con.Query<Entreprise, Participant, Entreprise>(
                SQL,
                (entreprise, participant) =>
                {
                    entreprise.Participants.Add(participant);
                    return entreprise;
                },
                splitOn: "Id");

            var resultats = entreprises.GroupBy(entreprises => entreprises.Id).Select(g =>
            {
                var groupEntreprise = g.First();
                Entreprise retourEntreprise = new Entreprise(groupEntreprise.Id, groupEntreprise.Nom, groupEntreprise.NIM);

                var participants = g.Select(p => p.Participants.Single()).ToList();
                if (participants[0] != null)
                    retourEntreprise.Participants = participants;
//                    groupEntreprise.Participants = participants;

                return retourEntreprise;
            });

            return resultats.ToList();
        }
    }
}
