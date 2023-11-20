using Group7Final.Models;

//Lai Connelly
namespace Group7Final.Data
{
    public class DessertContext : IDessert
    {
        FinalContext ctx;
        public DessertContext(FinalContext context)
        {
            ctx = context;
        }

        public int? AddDessert(Dessert d)
        {
            var dessert = this.GetDessertById(d.Id);
            if (dessert != null)
            {
                return null;
            }
            ctx.Desserts.Add(d);
            return ctx.SaveChanges();
        }

        public List<Dessert> GetAllDesserts()
        {
            return ctx.Desserts.ToList();
        }

        public Dessert GetDessertById(int Id)
        {
            return ctx.Desserts.FirstOrDefault(x => x.Id == Id);
        }

        public int? RemoveDessertById(int id)
        {
            var dessert = this.GetDessertById(id);
            if (dessert == null)
            {
                return null;
            }
            ctx.Remove(dessert);
            return ctx.SaveChanges();
        }

        public int? UpdateDessert(Dessert d)
        {
            ctx.Desserts.Update(d);
            return ctx.SaveChanges();
        }
    }
}
