﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EmployeeRecords.Models;

public partial class EmployeeDbContext : DbContext
{
    public EmployeeDbContext()
    {
    }

    public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<NewEmployee> NewEmployees { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<TblEmployee> TblEmployees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=1D0ECADE43FD5D3\\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True;Trust Server Certificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NewEmployee>(entity =>
        {
            entity.ToTable("NewEmployee");

            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Position).HasMaxLength(50);
        });

        modelBuilder.Entity<TblEmployee>(entity =>
        {
            entity.ToTable("tblEmployee");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EmployeeGender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.EmployeeName).HasMaxLength(50);
            entity.Property(e => e.EmployeeSalary).HasColumnType("decimal(18, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
