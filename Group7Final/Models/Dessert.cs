using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group7Final.Models
{
    public class Dessert
    {
        public int DessertId { get; set; }
        public string? TeamMember { get; set; }
        public string? DessertName { get; set; }
        public string? DessertType { get; set; }
        public string? DessertTemp { get; set; }
    }
}
