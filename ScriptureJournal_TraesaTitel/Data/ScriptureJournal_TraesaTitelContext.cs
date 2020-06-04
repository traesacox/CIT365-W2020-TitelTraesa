using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScriptureJournal_TraesaTitel.Models;

namespace ScriptureJournal_TraesaTitel.Data
{
    public class ScriptureJournal_TraesaTitelContext : DbContext
    {
        public ScriptureJournal_TraesaTitelContext (DbContextOptions<ScriptureJournal_TraesaTitelContext> options)
            : base(options)
        {
        }

        public DbSet<ScriptureJournal_TraesaTitel.Models.ScriptureJournal> ScriptureJournal { get; set; }
    }
}
