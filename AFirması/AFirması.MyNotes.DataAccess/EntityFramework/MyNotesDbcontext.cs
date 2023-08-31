using AFirması.MyNotes.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFirması.MyNotes.DataAccess.EntityFramework
{
    public class MyNotesDbContext : DbContext
    {
        public MyNotesDbContext(DbContextOptions<MyNotesDbContext> options) : base(options)
        {
        }

        public DbSet<Category>  Categories  { get; set; }
        public DbSet<Note> Notes { get; set; } 

    }
}
