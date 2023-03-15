using Moovee_2.Data;
using Moovee_2.Interfaces;
using Moovee_2.Models;
using System.Collections.Generic;
using System.Linq;

namespace Moovee_2.Repositories
{
	public class TvShowRepository : IRepository<TvShow>
	{
		private readonly ApplicationDbContext _context;

		public TvShowRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public void Create(TvShow item)
		{
			_context.TvShows.Add(item);
			_context.SaveChanges();
		}

		public void Delete(TvShow item)
		{
			_context.TvShows.Remove(item);
			_context.SaveChanges();
		}

		public TvShow GetById(int id)
		{
			var tvShow = _context.TvShows
			.FirstOrDefault(m => m.TvShowId == id);

			return tvShow;
		}

		public IEnumerable<TvShow> GetList()
		{
			var tvShows = _context.TvShows.ToList();
			return tvShows;
		}

		public void Update(TvShow item)
		{
			_context.TvShows.Update(item);
			_context.SaveChanges();
		}
	}
}
