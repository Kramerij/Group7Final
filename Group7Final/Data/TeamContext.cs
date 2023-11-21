using Group7Final.Models;
using Microsoft.AspNetCore.Mvc;

namespace Group7Final.Data
{
    public class TeamContext : ITeamService
    {
    
       
            FinalContext ctx;
            public TeamContext(FinalContext context)
            {
                ctx = context;
            }

            public int? AddTeam(Team t)
            {
                var team = this.GetTeamById(t.Id);
                if (team != null)
                {
                    return null;
                }
                ctx.Teams.Add(t);
                return ctx.SaveChanges();
            }

            public List<Team> GetAllTeams()
            {
                return ctx.Teams.ToList();
            }

            public Team GetTeamById(int Id)
            {
                return ctx.Teams.FirstOrDefault(x => x.Id == Id);
            }

            public int? RemoveTeamById(int id)
            {
                var team = this.GetTeamById(id);
                if (team == null)
                {
                    return null;
                }
                ctx.Remove(team);
                return ctx.SaveChanges();
            }

            public int? UpdateTeam(Team t)
            {
                ctx.Teams.Update(t);
                return ctx.SaveChanges();
            }
        }
    }

