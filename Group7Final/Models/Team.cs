using Microsoft.AspNetCore.Mvc;

namespace Group7Final.Models
{
    public class Team 
    {
        public int Id { get; set; }
        public string TeamMember { get; set; }
        public int Birthdate { get; set; }
        public string ProgramName { get; set; }
        public string YearName { get; set; }
    }
}
