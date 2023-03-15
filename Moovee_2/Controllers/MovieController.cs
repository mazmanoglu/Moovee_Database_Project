using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Moovee_2.Models;
using Moovee_2.Repositories;
using System.Data;
using System;
using System.Linq;

namespace Moovee_2.Controllers
{
    public class MovieController : Controller
    {
		private readonly MovieRepository _movieRepository;
		public MovieController(MovieRepository movieRepository)
		{
			_movieRepository = movieRepository;
		}


		public ViewResult Index(string searchString)
		{
			var movies = _movieRepository.GetList();
			if (!String.IsNullOrEmpty(searchString))
			{
				movies = movies.Where(s => s.Title.ToLower().Contains(searchString.ToLower())
				|| s.Genre.ToLower().Contains(searchString.ToLower())
				|| s.MainActress.ToLower().Contains(searchString.ToLower())).ToList();
			}

			return View(movies);
		}

		[Authorize(Roles = "Admin")]
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[Authorize(Roles = "Admin")]
		[HttpPost]
		public IActionResult Create(Movie movie)
		{
			_movieRepository.Create(movie);
			return RedirectToAction(nameof(Index));
		}

		[Authorize(Roles = "Admin")]
		[HttpGet]
		public IActionResult Update(int id)
		{
			var movie = _movieRepository.GetById(id);
			return View(movie);
		}

		[Authorize(Roles = "Admin")]
		[HttpPost]
		public IActionResult Update(Movie movie)
		{
			_movieRepository.Update(movie);
			return RedirectToAction(nameof(Index));
		}

		public IActionResult Details(int id)
		{
			var result = _movieRepository.GetById(id);
			return View(result);
		}

		[Authorize(Roles = "Admin")]
		[HttpGet]
		public IActionResult Delete(int id)
		{
			var tvShow = _movieRepository.GetById(id);
			return View(tvShow);
		}

		[Authorize(Roles = "Admin")]
		[HttpPost]
		public IActionResult Delete(Movie movie)
		{
			_movieRepository.Delete(movie);
			return RedirectToAction(nameof(Index));
		}
	}
}
