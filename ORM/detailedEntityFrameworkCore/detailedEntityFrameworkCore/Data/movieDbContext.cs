using detailedEntityFrameworkCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace detailedEntityFrameworkCore.Data
{
   public class movieDbContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Player> Players { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\Mssqllocaldb; Database=moviesCloneDb; Integrated Security=yes");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>().Property(x => x.Name)
                                       .IsRequired()
                                       .HasMaxLength(250);


            modelBuilder.Entity<Film>().HasOne(film => film.Director)
                                       .WithMany(director => director.Films)
                                       .HasForeignKey(f => f.DirectorId)
                                       .OnDelete(DeleteBehavior.SetNull);


            modelBuilder.Entity<FilmsPlayer>().HasKey("FilmId", "PlayerId");

            modelBuilder.Entity<Film>().HasMany(f => f.Players)
                                       .WithOne(fp => fp.Film)
                                       .HasForeignKey(x => x.FilmId)
                                       .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Player>().HasMany(p => p.Films)
                                         .WithOne(f => f.Player)
                                         .HasForeignKey(x => x.PlayerId)
                                         .OnDelete(DeleteBehavior.NoAction);


            //modelBuilder.Entity<Director>().HasData(new Director { Id=1, Name = "Nuri Bilge", LastName = "Ceylan", Info = "Başarılı yönetmen" });

            //modelBuilder.Entity<Player>().HasData(new Player { Id=1, Name = "Doğu", LastName = "Demirkol", Info = "Başarılı bir komedyen" });

            //modelBuilder.Entity<Film>().HasData(new Film { Id=1, Name = "Ahlat Ağacı", DirectorId = 1, Rating = 5 });
            //modelBuilder.Entity<FilmsPlayer>().HasData(new FilmsPlayer { FilmId = 1, PlayerId = 1, Role = "Başrol oyuncusu" });




           
            //modelBuilder.Entity<Player>().HasMany(f=>f.Films)
            //                             .


                                     




        }


    }
}
