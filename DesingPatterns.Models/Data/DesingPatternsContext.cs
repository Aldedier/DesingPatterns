using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DesingPatterns.Models.Data;

public partial class DesingPatternsContext : DbContext
{
    public DesingPatternsContext()
    {
    }

    public DesingPatternsContext(DbContextOptions<DesingPatternsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Beer> Beers { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=PC-MARTINEZ\\SQLEXPRESS; Database=DesingPatterns; Trusted_Connection=SSPI; MultipleActiveResultSets=True; Trust Server Certificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Beer>(entity =>
        {
            entity.ToTable("Beer");

            entity.Property(e => e.BrandId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Style)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.ToTable("Brand");

            entity.Property(e => e.BrandId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
