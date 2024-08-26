using Microsoft.EntityFrameworkCore;
using Models;

namespace Contexts;

public class PruebaContext : DbContext
{
    public DbSet<Libro> Libro { get; set; }
    public DbSet<AutorLibro> AutorLibro { get; set; }
    public DbSet<Ciudades> Ciudades { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source=JGARCIA; Initial Catalog=PruebaDB; User Id=sa; Password=1234; TrustServerCertificate=True");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Libro>(entity =>
    {
        entity.HasKey(e => e.LibroId);

        entity.Property(e => e.Nombre)
            .IsRequired();

        entity.Property(e => e.AnioPublicacion)
            .IsRequired();

        entity.HasOne(e => e.Autor)
            .WithMany(a => a.Libros)
            .HasForeignKey(e => e.AutorId)
            .OnDelete(DeleteBehavior.Restrict);
    });

        modelBuilder.Entity<AutorLibro>(entity =>
        {
            entity.HasKey(e => e.AutorId);

            entity.Property(e => e.Nombre)
                .IsRequired();

            entity.HasOne(e => e.Ciudad)
                .WithMany(c => c.Autores)
                .HasForeignKey(e => e.CiudadId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Ciudades>(entity =>
        {
            entity.HasKey(e => e.CiudadId);

            entity.Property(e => e.Nombre)
                .IsRequired();
        });
    }

}