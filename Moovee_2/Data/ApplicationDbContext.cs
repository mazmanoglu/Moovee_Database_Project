using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Moovee_2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moovee_2.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Movie>()
			.HasData(
					new Movie { MovieId = 1, Length = 125, Title = "Titanic", Genre = "Romance", MainActress = "Kate Winslet", DateRelease = new DateTime(1997, 12, 19), Description = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic", ImageUrl = "Titanic.jpg", ImdbUrl = "https://www.imdb.com/title/tt0120338/", ActressImage="katewinslet.jpg" },
					new Movie { MovieId = 2, Length = 105, Title = "Inglorious Basterds", Genre = "Action", MainActress = "Diane Kruger", DateRelease = new DateTime(2009, 08, 21), Description = "In Nazi-occupied France during World War II, a plan to assasinate Nazi leaders by a group of Jewish U.S. soldiers coincides with a theatre owner's vengeful plans for the same", ImageUrl = "InBasterds.jpg", ImdbUrl = "https://www.imdb.com/title/tt0361748/", ActressImage="kruger.jpg" },
					new Movie { MovieId = 3, Length = 135, Title = "Star Trek - Into Darkness", Genre = "Sci-Fi", MainActress = "Zoe Saldana", DateRelease = new DateTime(2013, 05, 16), Description = "After the crew of the Enterprise find an unstoppable force of terror from within their own organization, Captain Kirk leads a manhunt to a war-zone world to capture a one-man weapon of mass destruction", ImageUrl = "StarTrek.jpg", ImdbUrl = "https://www.imdb.com/title/tt1408101/", ActressImage="saldana.jpg" },
					new Movie { MovieId = 4, Length = 110, Title = "Top Gun", Genre = "Action-Drama", MainActress = "Kelly McGills", DateRelease = new DateTime(1986, 05, 16), Description = "As students at the United States Navy's elite fighter weapons school compete to be best in the class, one daring young pilot learns a few things from a civilian instructor that are not taught in the classroom.", ImageUrl = "topgun.jpg", ImdbUrl = "https://www.imdb.com/title/tt0092099/", ActressImage="kelly.jpg" },
					new Movie { MovieId = 5, Length = 175, Title = "The Godfather", Genre = "Crime / Drama", MainActress = "Simonetta Stefanelli", DateRelease = new DateTime(1972, 03, 17), Description = "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son.", ImageUrl = "godfather.jpg", ImdbUrl = "https://www.imdb.com/title/tt0068646/", ActressImage="godfather.jpg" },
					new Movie { MovieId = 6, Length = 100, Title = "Amsterdam", Genre = "Drama / History", MainActress = "Margot Robbie", DateRelease = new DateTime(2022, 10, 07), Description = "Set in the '30s, it follows three friends who witness a murder, become suspects themselves, and uncover one of the most outrageous plots in American history.", ImageUrl = "amsterdam.jpg", ImdbUrl = "https://www.imdb.com/title/tt10304142/", ActressImage="margot.jpg" }
					);

			modelBuilder.Entity<TvShow>()
			.HasData(
					new TvShow { TvShowId = 1, Length = 140, Title = "Game of Thrones", Genre = "Action / Fantasy", MainActress = "Emilia Clarke", DateRelease = new DateTime(2011, 04, 17), Description = "Nine noble families fight for control over the lands of Westeros, while an ancient enemy returns after being dormant for millennia.", ImageUrl = "gameofthrones.jpg", ImdbUrl = "https://www.imdb.com/title/tt0944947/" },
					new TvShow { TvShowId = 3, Length = 62, Title = "Breaking Bad", Genre = "Science", MainActress = "Anna Gunn", DateRelease = new DateTime(2008, 01, 20), Description = "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.", ImageUrl = "breakingbad.jpg", ImdbUrl = "https://www.imdb.com/title/tt0903747/" },
					new TvShow { TvShowId = 4, Length = 10, Title = "Lord of the Rings - Rings Power", Genre = "Sci-Fi / Fantasy", MainActress = "Morfydd Clark", DateRelease = new DateTime(2022, 09, 02), Description = "Epic drama set thousands of years before the events of J.R.R. Tolkien's 'The Hobbit' and 'The Lord of the Rings' follows an ensemble cast of characters, both familiar and new, as they confront the long-feared re-emergence of evil to Middle-earth.", ImageUrl = "ringsofpower.jpg", ImdbUrl = "https://www.imdb.com/title/tt7631058/" },
					new TvShow { TvShowId = 5, Length = 10, Title = "Band of Brothers", Genre = "Drama / History / War", MainActress = "----", DateRelease = new DateTime(2001, 09, 09), Description = "The story of Easy Company of the U.S. Army 101st Airborne Division and their mission in World War II Europe, from Operation Overlord to V-J Day.", ImageUrl = "bandofbrothers.jpg", ImdbUrl = "https://www.imdb.com/title/tt0185906/" },
					new TvShow { TvShowId = 6, Length = 5, Title = "Chernobyl", Genre = "Drama / History / Thriller", MainActress = "Jessie Buckley", DateRelease = new DateTime(2019, 05, 07), Description = "In April 1986, an explosion at the Chernobyl nuclear power plant in the Union of Soviet Socialist Republics becomes one of the world's worst man-made catastrophes.", ImageUrl = "chernobyl.jpg", ImdbUrl = "https://www.imdb.com/title/tt7366338/" }
					);

			base.OnModelCreating(modelBuilder);
		}

		public DbSet<Movie> Movies { get; set; }
		public DbSet<TvShow> TvShows { get; set; }
	}
}
