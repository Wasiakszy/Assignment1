using Assignment1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assignment1.Data
{
    public class AssignmentContext : DbContext
    {
        public DbSet<NoteModel> NoteModel { get; set; }
        public DbSet<NotePreviousVersion> NotePreviousVersion { get; set; }

    }
}