﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Pr3_PartnersDB.Models;

public partial class PartnersContext : DbContext
{
    public PartnersContext()
    {
    }

    public PartnersContext(DbContextOptions<PartnersContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Partner> Partners { get; set; }

    public virtual DbSet<PartnerType> PartnerTypes { get; set; }

    public virtual DbSet<PartnersProduct> PartnersProducts { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductType> ProductTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=partners;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Partner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_partners");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FullNameOfCeo).HasColumnName("fullNameOfCeo");
            entity.Property(e => e.IdPartnerType).HasColumnName("idPartnerType");
            entity.Property(e => e.Inn).HasColumnName("INN");
            entity.Property(e => e.LegalAdress).HasColumnName("legalAdress");
            entity.Property(e => e.NameOfPartner).HasColumnName("nameOfPartner");
            entity.Property(e => e.PhoneNumber).HasColumnName("phoneNumber");
            entity.Property(e => e.Rating).HasColumnName("rating");

            entity.HasOne(d => d.IdPartnerTypeNavigation).WithMany(p => p.Partners)
                .HasForeignKey(d => d.IdPartnerType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_partners_partnerTypes");
        });

        modelBuilder.Entity<PartnerType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_partnerTypes");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.TypeOfPartner).HasColumnName("typeOfPartner");
        });

        modelBuilder.Entity<PartnersProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_partners_products");

            entity.ToTable("Partners_Products");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.IdOfPartner).HasColumnName("idOfPartner");
            entity.Property(e => e.IdOfProduct).HasColumnName("idOfProduct");
            entity.Property(e => e.SaleDate).HasColumnName("saleDate");

            entity.HasOne(d => d.IdOfPartnerNavigation).WithMany(p => p.PartnersProducts)
                .HasForeignKey(d => d.IdOfPartner)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_partnersProducts_partners");

            entity.HasOne(d => d.IdOfProductNavigation).WithMany(p => p.PartnersProducts)
                .HasForeignKey(d => d.IdOfProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_partnersProducts_products");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_products");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Article).HasColumnName("article");
            entity.Property(e => e.IdProductType).HasColumnName("idProductType");
            entity.Property(e => e.NameOfProduct).HasColumnName("nameOfProduct");
            entity.Property(e => e.PriceMin)
                .HasColumnType("money")
                .HasColumnName("priceMin");

            entity.HasOne(d => d.IdProductTypeNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdProductType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_products_productTypes");
        });

        modelBuilder.Entity<ProductType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_productTypes");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.TypeOfProduct).HasColumnName("typeOfProduct");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}