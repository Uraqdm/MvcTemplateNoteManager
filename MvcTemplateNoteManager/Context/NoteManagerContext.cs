using Microsoft.EntityFrameworkCore;
using MvcTemplateNoteManager.Models;

namespace MvcTemplateNoteManager.Context
{
    public class NoteManagerContext : DbContext
    {
        public NoteManagerContext(DbContextOptions options) : base(options) { }

        public DbSet<Note> Notes { get; set; }
    }
}
