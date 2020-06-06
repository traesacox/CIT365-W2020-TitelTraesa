using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScriptureJournal3_Titel.Models;

namespace ScriptureJournal3_Titel.Data
{
    public class ScriptureJournal3_TitelContext : DbContext
    {
        public ScriptureJournal3_TitelContext (DbContextOptions<ScriptureJournal3_TitelContext> options)
            : base(options)
        {
        }

        public DbSet<ScriptureJournal3_Titel.Models.Scripture> Scripture { get; set; }
    }
}
