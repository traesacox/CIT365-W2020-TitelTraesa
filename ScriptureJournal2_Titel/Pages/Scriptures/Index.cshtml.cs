using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ScriptureJournal2_Titel.Models;

namespace ScriptureJournal2_Titel.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly ScriptureJournal2_Titel.Models.ScriptureJournal2_TitelContext _context;

        public IndexModel(ScriptureJournal2_Titel.Models.ScriptureJournal2_TitelContext context)
        {
            _context = context;
        }

        public IList<ScriptureJournal> ScriptureJournal { get;set; }

        public async Task OnGetAsync()
        {
            ScriptureJournal = await _context.ScriptureJournal.ToListAsync();
        }
    }
}
