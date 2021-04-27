using Microsoft.EntityFrameworkCore;
using MvcTemplateNoteManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcTemplateNoteManager.Context
{
    public class NoteManagerContext : DbContext
    {
        public NoteManagerContext(DbContextOptions options) : base(options) { }

        public DbSet<Note> Notes { get; set; }
        public DbSet<Models.Task> Tasks { get; set; }
    }
}
