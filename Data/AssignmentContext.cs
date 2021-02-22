using Assignment1.Models;

using System.Data.Entity;

namespace Assignment1.Data
{
    public class AssignmentContext : DbContext
    {
        public DbSet<NoteModel> NoteModel { get; set; }
        public DbSet<NotePreviousVersion> NotePreviousVersion { get; set; }

       
    }
}