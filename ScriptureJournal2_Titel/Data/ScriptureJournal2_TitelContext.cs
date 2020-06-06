using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ScriptureJournal2_Titel.Models
{
    public class ScriptureJournal2_TitelContext : DbContext
    {
        public ScriptureJournal2_TitelContext (DbContextOptions<ScriptureJournal2_TitelContext> options)
            : base(options)
        {
        }

        public DbSet<ScriptureJournal2_Titel.Models.ScriptureJournal> ScriptureJournal { get; set; }
    }
}
