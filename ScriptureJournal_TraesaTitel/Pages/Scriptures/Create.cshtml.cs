using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ScriptureJournal_TraesaTitel.Data;
using ScriptureJournal_TraesaTitel.Models;

namespace ScriptureJournal_TraesaTitel.Pages.Scriptures
{
    public class CreateModel : PageModel
    {
        private readonly ScriptureJournal_TraesaTitel.Data.ScriptureJournal_TraesaTitelContext _context;

        public CreateModel(ScriptureJournal_TraesaTitel.Data.ScriptureJournal_TraesaTitelContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ScriptureJournal ScriptureJournal { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ScriptureJournal.Add(ScriptureJournal);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
