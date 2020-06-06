using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ScriptureJournal2_Titel.Models;

namespace ScriptureJournal2_Titel.Pages.Scriptures
{
    public class CreateModel : PageModel
    {
        private readonly ScriptureJournal2_Titel.Models.ScriptureJournal2_TitelContext _context;

        public CreateModel(ScriptureJournal2_Titel.Models.ScriptureJournal2_TitelContext context)
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
