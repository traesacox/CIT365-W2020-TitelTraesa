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
    public class IndexModel : PageModel
    {
        private readonly ScriptureJournal_TraesaTitel.Data.ScriptureJournal_TraesaTitelContext _context;

        public IndexModel(ScriptureJournal_TraesaTitel.Data.ScriptureJournal_TraesaTitelContext context)
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
