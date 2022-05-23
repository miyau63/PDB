using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebApplication4.Models
{
    public class MusicianDBContext:DbContext
    {
        public DbSet<Musician> Musicians { get; set; }
        public DbSet<Instrument> Instruments { get; set; }

        public MusicianDBContext(bool bFromScratch) : base()
        {
            if (bFromScratch)
            {
                Database.EnsureDeleted();
                Database.EnsureCreated();
            }
        }
        public MusicianDBContext(DbContextOptions<MusicianDBContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }


    }
}


