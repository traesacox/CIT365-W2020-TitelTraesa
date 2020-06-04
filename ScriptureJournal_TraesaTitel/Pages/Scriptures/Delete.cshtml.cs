using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ScriptureJournal_TraesaTitel.Data;
using ScriptureJournal_TraesaTitel.Models;

namespace ScriptureJournal_TraesaTitel.Pages.Scriptures
{
    public class DeleteModel : PageModel
    {
        private readonly ScriptureJournal_TraesaTitel.Data.ScriptureJournal_TraesaTitelContext _context;

        public DeleteModel(ScriptureJournal_TraesaTitel.Data.ScriptureJournal_TraesaTitelContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ScriptureJournal = await _context.ScriptureJournal.FindAsync(id);

            if (ScriptureJournal != null)
            {
                _context.ScriptureJournal.Remove(ScriptureJournal);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
