
using Group7Final.Models;

namespace Group7Final.Data
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
        Movie GetMovieById(int id);
        int? RemoveMovieById(int id);
    }
}
