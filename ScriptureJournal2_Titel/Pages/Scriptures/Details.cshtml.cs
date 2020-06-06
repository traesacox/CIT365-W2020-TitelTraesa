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
    public class DetailsModel : PageModel
    {
        private readonly ScriptureJournal2_Titel.Models.ScriptureJournal2_TitelContext _context;

        public DetailsModel(ScriptureJournal2_Titel.Models.ScriptureJournal2_TitelContext context)
        {
            _context = context;
        }

        public ScriptureJournal ScriptureJournal { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ScriptureJournal = await _context.ScriptureJournal.FirstOrDefaultAsync(m => m.ID == id);

            if (ScriptureJournal == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
