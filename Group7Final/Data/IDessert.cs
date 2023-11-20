using Group7Final.Models;

//Lai Connelly
namespace Group7Final.Data
{
    public interface IDessert
    {
        int? AddDessert(Dessert d);
        List<Dessert> GetAllDesserts();
        Dessert GetDessertById(int id);
        int? RemoveDessertById(int id);
        int? UpdateDessert(Dessert d);
    }
}
