using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using RazorPagesMovie.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Cryptography.X509Certificates;

namespace RazorPagesMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie.Models.RazorPagesMovieContext _context;

        public IndexModel(RazorPagesMovie.Models.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        [BindProperty(SupportsGet = true)]//required for binding on GET requests
        public string SearchString { get; set; }//the text users enter in the search text box

        //Requires using Microsoft.ASPNetCore.Mvc.Rendering;
        public SelectList Genres { get; set; } //SelectList requires using Microsoft.AspNetCore.Mvc.Renderign

        [BindProperty(SupportsGet =true)]
        public string MovieGenre { get; set; }

        //called to return as list of movies to the Razor Page to initalize the Sate for the Page
        public async Task OnGetAsync()
        {
            //Use LINQ to get list of Genres
            IQueryable<string> genreQuery = from m in _context.Movie orderby m.Genre select m.Genre;

            //creates a LINQ query to select the movies - using System.Linq
            var movies = from m in _context.Movie select m;//movies is the entire list of movies

            // if not null or empty then the moview query is modified to filter on the search string
            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));//movies here is the filtered list by title
            }
            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.Genre == MovieGenre); //movies here is the filtered list by Genre
            }
            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Movie = await movies.ToListAsync();
        }
    }
}
