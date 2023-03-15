using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moovee_2.Models;
using Moovee_2.Repositories;
using Moovee_2.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Moovee_EindProject.Controllers
{
	public class HomeController : Controller
	{
		private readonly MovieRepository _movieRepository;
		private readonly TvShowRepository _tvShowRepository;
		HomePageViewModel vm = new HomePageViewModel();

		public HomeController(MovieRepository movieRepository, TvShowRepository tvShowRepository)
		{
			_movieRepository = movieRepository;
			_tvShowRepository = tvShowRepository;
		}

		public IActionResult Index(string searchString)
		{
			vm.Movies = _movieRepository.GetList();
			vm.TvShows = _tvShowRepository.GetList();

			if (!String.IsNullOrEmpty(searchString))
			{
				vm.Movies = vm.Movies.Where(s => s.Title.ToLower().Contains(searchString.ToLower())).ToList();
				vm.TvShows = vm.TvShows.Where(s => s.Title.ToLower().Contains(searchString.ToLower())).ToList();
			}

			return View(vm);
		}


		// movie or tv show?
		public IActionResult Details1(int id)
		{
			var movie = _movieRepository.GetById(id);
			return View(movie);
		}

		public IActionResult Details2(int id)
		{
			var tv = _tvShowRepository.GetById(id);
			return View(tv);
		}


		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
