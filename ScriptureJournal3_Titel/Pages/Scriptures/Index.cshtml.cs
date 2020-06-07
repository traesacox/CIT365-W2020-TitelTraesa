using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ScriptureJournal3_Titel.Data;
using ScriptureJournal3_Titel.Models;

namespace ScriptureJournal3_Titel.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly ScriptureJournal3_Titel.Data.ScriptureJournal3_TitelContext _context;

        public IndexModel(ScriptureJournal3_Titel.Data.ScriptureJournal3_TitelContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; }
        [BindProperty(SupportsGet =true)]
        public string SearchString { get; set; }

        //Requires using Microsoft.AspNetCore.MVC.Rendering;
        public SelectList Books { get; set; } 
        [BindProperty(SupportsGet =true)]
        public string ScriptureBook { get; set; }
        
        //Adding Sort functionality
        public string BookSort { get; set; }
        public string DateSort { get; set; }

        public string CurrentSort { get; set; }
        public async Task OnGetAsync( string sortOrder)

        {
            BookSort = String.IsNullOrEmpty(sortOrder) ? "book_desc" : "";

            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
           

            //Use Linq to get list of books that retrieves all the books from the database
            IQueryable<string> bookQuery = from s in _context.Scripture orderby s.Book select s.Book;

           
            //Create a complete quearable list of all entries to sort and then filter
            IQueryable <Scripture> scriptures = from s in _context.Scripture select s;

            switch (sortOrder)
            {
                case "book_desc":
                    scriptures = scriptures.OrderByDescending(s => s.Book);
                    break;
                case "Date":
                    scriptures = scriptures.OrderBy(s => s.DateAdded);
                    break;
                case "date_desc":
                    scriptures = scriptures.OrderByDescending(s => s.DateAdded);
                    break;
                default:
                    scriptures = scriptures.OrderBy(s => s.Book);
                    break;
            }

            if(!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(b => b.Notes.Contains(SearchString));
            }

            if(!string.IsNullOrEmpty(ScriptureBook))
            {
                scriptures = scriptures.Where(x => x.Book == ScriptureBook);
            }
            //Makes a list of Distrinct Book - no duplicates
            Books = new SelectList(await bookQuery.Distinct().ToListAsync());

            Scripture = await scriptures.ToListAsync();
        }
    }
}
