using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;

namespace Moovee_2.Models
{
	public class TvShow
	{
		[Key]
		public int TvShowId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		[Display(Name = "Image")]
		public string ImageUrl { get; set; }
		[Display(Name = "Total Episodes")]
		public int Length { get; set; }
		[BindProperty, DataType(DataType.Date)]
		[Display(Name = "Date Release")]
		public DateTime DateRelease { get; set; }
		public string Genre { get; set; }
		[MaxLength(50)]
		[Display(Name = "Main Actress")]
		public string MainActress { get; set; }
		[Display(Name = "IMDB link")]
		public string ImdbUrl { get; set; }
	}
}
