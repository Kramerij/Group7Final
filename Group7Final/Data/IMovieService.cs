
using Group7Final.Models;

namespace Group7Final.Data
{
    public interface IMovieService
    {
        int? AddMovie(Movie m);
        List<Movie> GetAllMovies();
        Movie GetMovieById(int id);
        int? RemoveMovieById(int id);
        int? UpdateMovie(Movie m);
    }
}
