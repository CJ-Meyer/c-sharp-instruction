using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApiProject;

public partial class BmdbContext : DbContext
{
    public BmdbContext()
    {
    }

    public BmdbContext(DbContextOptions<BmdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actor> Actors { get; set; }

    public virtual DbSet<Credit> Credits { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<MovieCopy> MovieCopies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=CHRISTIANLAPTOP\\SQLEXPRESS01;Database=BMDB;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Actor__3214EC273113E51A");

            entity.ToTable("Actor");

            entity.HasIndex(e => new { e.FirstName, e.LastName, e.BirthDate }, "UC_Actor").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Credit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Credit__3214EC27CCBEAF15");

            entity.ToTable("Credit");

            entity.HasIndex(e => new { e.MovieId, e.ActorId }, "UC_Credit").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActorId).HasColumnName("ActorID");
            entity.Property(e => e.MovieId).HasColumnName("MovieID");
            entity.Property(e => e.Role)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Actor).WithMany(p => p.Credits)
                .HasForeignKey(d => d.ActorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CreditActor");

            entity.HasOne(d => d.Movie).WithMany(p => p.Credits)
                .HasForeignKey(d => d.MovieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CreditMovie");
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Movie__3214EC275D306CDB");

            entity.ToTable("Movie");

            entity.HasIndex(e => new { e.Title, e.Year }, "UC_Movie").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Director)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Rating)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(75)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MovieCopy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MovieCopy");

            entity.Property(e => e.Director)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Rating)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(75)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
