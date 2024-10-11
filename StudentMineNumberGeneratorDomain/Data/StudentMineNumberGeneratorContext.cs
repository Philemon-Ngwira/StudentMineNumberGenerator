﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace StudentMineNumberGeneratorDomain.Data;

public partial class StudentMineNumberGeneratorContext : DbContext
{
    public StudentMineNumberGeneratorContext(DbContextOptions<StudentMineNumberGeneratorContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Certification> Certification { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<MineNumberType> MineNumberType { get; set; }

    public virtual DbSet<Site> Sites { get; set; }

    public virtual DbSet<Status> Status { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Certification>(entity =>
        {
            entity.HasKey(e => e.CertId);

            entity.Property(e => e.CertificateName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.HasKey(e => e.GenderId);

            entity.Property(e => e.GenderId).HasColumnName("GenderID");
            entity.Property(e => e.Gender1)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MineNumberType>(entity =>
        {
            entity.HasKey(e => e.MntypeId);

            entity.Property(e => e.MntypeId).HasColumnName("MNTypeId");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Site>(entity =>
        {
            entity.HasKey(e => e.SiteId);

            entity.Property(e => e.SiteName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.Property(e => e.Status1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Status");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId);

            entity.Property(e => e.CostCenter).IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.GenderNavigation).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.Gender)
                .HasConstraintName("FK_Transactions_Genders");

            entity.HasOne(d => d.SiteNavigation).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.Site)
                .HasConstraintName("FK_Transactions_Sites");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.Status)
                .HasConstraintName("FK_Transactions_Status");

            entity.HasOne(d => d.TypeNavigation).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.Type)
                .HasConstraintName("FK_Transactions_MineNumberType");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}