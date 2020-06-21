using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;
using SQLitePCL;

namespace MvcMovie.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MvcMovieContext _context;
        private readonly IHostingEnvironment hostingEnvironment;

        public MoviesController(MvcMovieContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        // GET: Movies
        public async Task<IActionResult> Index( string movieGenre, string searchString, string sortOrder)
        {
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";

            //use LINQ to get list of genres
            IQueryable<string> genreQuery = from m in _context.Movie
                                            orderby m.Genre
                                            select m.Genre;


            //Creates a LINQ query to select the movies
            var movies = from m in _context.Movie select m;

            switch (sortOrder)
            {
                case "Date":
                    movies = movies.OrderBy(s => s.ReleaseDate);
                    break;
                case "date_desc":
                    movies = movies.OrderByDescending(s => s.ReleaseDate);
                    break;
                default:
                    movies = movies.OrderBy(s => s.Title);
                    break;
            }

            //Filter list by searchString
            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title.Contains(searchString));

            }

            if (!string.IsNullOrEmpty(movieGenre))
            {
                movies = movies.Where(x => x.Genre == movieGenre);
            }

            var movieGenreVM = new MovieCreateViewModel
            {
                Genres = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Movies = await movies.ToListAsync()
            };

            return View(movieGenreVM);
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
       //Old One ---- public async Task<IActionResult> Create([Bind("Id,Title,ReleaseDate,Genre,Price,Rating,PhotoPath")] Movie movie)
        public async Task<IActionResult> Create([Bind("Id,Title,ReleaseDate,Genre,Price,Rating,PhotoPath")]MovieCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if(model.Photo != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
                   uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));

                }

                Movie movie = new Movie
                {

                    Title = model.Title,
                    ReleaseDate = model.ReleaseDate,
                    Genre = model.Genre,
                    Price = model.Price,
                    Rating = model.Rating,
                    PhotoPath = uniqueFileName


                };

                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", new { id = movie.Id });
            }
            return View(model);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)

            {

                return NotFound();

            }

            var movie = await _context.Movie.FindAsync(id);

            if (movie == null)

            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,ReleaseDate,Genre,Price,Rating")] Movie movie)

        {

            if (id != movie.Id)

            {

                return NotFound();

            }



            if (ModelState.IsValid)

            {

                try

                {

                    _context.Update(movie);

                    await _context.SaveChangesAsync();

                }

                catch (DbUpdateConcurrencyException)

                {

                    if (!MovieExists(movie.Id))

                    {

                        return NotFound();

                    }

                    else

                    {

                        throw;

                    }

                }

                return RedirectToAction(nameof(Index));

            }

            return View(movie);

        }



        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie = await _context.Movie.FindAsync(id);
            _context.Movie.Remove(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
            return _context.Movie.Any(e => e.Id == id);
        }
    }
}
