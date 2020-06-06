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
        

        public async Task OnGetAsync()

        {
            //Use Linq to get list of books
            IQueryable<string> bookQuery = from s in _context.Scripture orderby s.Book select s.Book;

            var scriptures = from s in _context.Scripture select s;

            if(!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(b => b.Notes.Contains(SearchString));
            }

            if(!string.IsNullOrEmpty(ScriptureBook))
            {
                scriptures = scriptures.Where(x => x.Book == ScriptureBook);
            }

            Scripture = await scriptures.ToListAsync();
        }
    }
}
