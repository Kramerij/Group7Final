using Microsoft.AspNetCore.Mvc;
using Group7Final.Models;

namespace Group7Final.Data
{
    public interface ITeamService
    {
        int? AddTeam(Team t);
        List<Team> GetAllTeams();
        Team GetTeamById(int id);
        int? RemoveTeamById(int id);
        int? UpdateTeam(Team t);
    }
}
