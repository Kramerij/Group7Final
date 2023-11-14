using Group7Final.Models;
namespace Group7Final.Data
{
    public class MovieService : IMovieService
    {
        FinalContext ctx;
        public  MovieService(FinalContext context)
        {
            ctx = context;
        }

        public int? AddMovie(Movie m)
        {
            var movie = this.GetMovieById(m.Id); 
            if (movie != null)
            {
                return null;
            }
            ctx.Movies.Add(m);
            return ctx.SaveChanges();
        }

        public List<Movie> GetAllMovies() 
        {
            return ctx.Movies.ToList();
        }

        public Movie GetMovieById(int Id)
        {
            return ctx.Movies.FirstOrDefault(x => x.Id == Id);
        }

        public int? RemoveMovieById(int id)
        {
            var movie = this.GetMovieById(id);
            if (movie == null)
            {
                return null;
            }
            ctx.Remove(movie);
            return ctx.SaveChanges();
        }

        public int? UpdateMovie(Movie m)
        {
            ctx.Movies.Update(m);
            return ctx.SaveChanges();
        }
    }
}
