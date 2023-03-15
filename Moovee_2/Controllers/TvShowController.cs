using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Moovee_2.Models;
using Moovee_2.Repositories;
using System;
using System.Data;
using System.Linq;

namespace Moovee_2.Controllers
{
    public class TvShowController : Controller
    {
		private readonly TvShowRepository _tvShowRepository;
		public TvShowController (TvShowRepository tvShowRepository)
		{
			_tvShowRepository = tvShowRepository;
		}


		public ViewResult Index(string searchString)
		{
			var tvShows = _tvShowRepository.GetList();
			if (!String.IsNullOrEmpty(searchString))
			{
				tvShows = tvShows.Where(s => s.Title.ToLower().Contains(searchString.ToLower())
				|| s.Genre.ToLower().Contains(searchString.ToLower())
				|| s.MainActress.ToLower().Contains(searchString.ToLower())).ToList();
			}

			return View(tvShows);
		}

		[Authorize(Roles = "Admin")]
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[Authorize(Roles = "Admin")]
		[HttpPost]
		public IActionResult Create(TvShow tvShow)
		{
			_tvShowRepository.Create(tvShow);
			return RedirectToAction(nameof(Index));
		}

		[Authorize(Roles = "Admin")]
		[HttpGet]
		public IActionResult Update(int id)
		{
			var tvShow = _tvShowRepository.GetById(id);
			return View(tvShow);
		}

		[Authorize(Roles = "Admin")]
		[HttpPost]
		public IActionResult Update(TvShow tvShow)
		{
			_tvShowRepository.Update(tvShow);
			return RedirectToAction(nameof(Index));
		}

		public IActionResult Details(int id)
		{
			var result = _tvShowRepository.GetById(id);
			return View(result);
		}

		[Authorize(Roles = "Admin")]
		[HttpGet]
		public IActionResult Delete(int id)
		{
			var tvShow = _tvShowRepository.GetById(id);
			return View(tvShow);
		}

		[Authorize(Roles = "Admin")]
		[HttpPost]
		public IActionResult Delete(TvShow tvShow)
		{
			_tvShowRepository.Delete(tvShow);
			return RedirectToAction(nameof(Index));
		}
	}
}
