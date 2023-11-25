using Group7Final.Models;
using System.Net.Http.Headers;

namespace Group7Final.Data
{
	public class VidGameService : IVidGameService
	{
		FinalContext _context;
		public VidGameService(FinalContext context)
		{
			_context = context;
		}
		public int? AddGame(Vidgame v)
		{
			var vidgame = this.GetGameById(v.Id);
			if (vidgame != null)
			{
				return null;
			}
			_context.Games.Add(v);
			return _context.SaveChanges();
		}


		public List<Vidgame> GetAllGames()
		{
			return _context.Games.ToList();
		}

		public Vidgame GetGameById(int Id)
		{
			return _context.Games.FirstOrDefault(x => x.Id == Id);
		}

		public int? RemoveGameById(int id)
		{
			var vidgame = this.GetGameById(id);
			if (vidgame == null)
			{
				return null;
			}
			_context.Games.Remove(vidgame);
			return _context.SaveChanges();
		}

		public int? UpdateGame(Vidgame v)
		{
			_context.Games.Update(v);
			return _context.SaveChanges();
		}
	}
}
