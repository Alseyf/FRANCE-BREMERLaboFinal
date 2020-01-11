using System;
using System.Data.Entity;

namespace DAL
{
    public class FilmDBContext : DbContext
    {
        public FilmDBContext() : base("FilmDBEntities")
        {
            //this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<CharacterActor> CharacterActors { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }

    }
}
