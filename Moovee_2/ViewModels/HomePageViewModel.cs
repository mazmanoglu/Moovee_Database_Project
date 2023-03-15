using Moovee_2.Models;
using System.Collections;
using System.Collections.Generic;

namespace Moovee_2.ViewModels
{
	public class HomePageViewModel
	{
		public IEnumerable<Movie> Movies { get; set; }
		public IEnumerable<TvShow> TvShows { get; set; }

	}
}
