using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ScriptureJournal3_Titel.Data;
using ScriptureJournal3_Titel.Models;

namespace ScriptureJournal3_Titel.Pages.Scriptures
{
    public class DeleteModel : PageModel
    {
        private readonly ScriptureJournal3_Titel.Data.ScriptureJournal3_TitelContext _context;

        public DeleteModel(ScriptureJournal3_Titel.Data.ScriptureJournal3_TitelContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Scripture Scripture { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Scripture = await _context.Scripture.FirstOrDefaultAsync(m => m.ID == id);

            if (Scripture == null)
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

            Scripture = await _context.Scripture.FindAsync(id);

            if (Scripture != null)
            {
                _context.Scripture.Remove(Scripture);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
