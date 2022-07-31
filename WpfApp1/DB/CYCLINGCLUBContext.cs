using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WpfApp1.DB
{
    public partial class CYCLINGCLUBContext : DbContext
    {
        public CYCLINGCLUBContext()
        {
        }

        public CYCLINGCLUBContext(DbContextOptions<CYCLINGCLUBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bycicle> Bycicles { get; set; } = null!;
        public virtual DbSet<Calendar> Calendars { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Enrollment> Enrollments { get; set; } = null!;
        public virtual DbSet<Fee> Fees { get; set; } = null!;
        public virtual DbSet<Manager> Managers { get; set; } = null!;
        public virtual DbSet<Member> Members { get; set; } = null!;
        public virtual DbSet<Outing> Outings { get; set; } = null!;
        public virtual DbSet<Outingregistration> Outingregistrations { get; set; } = null!;
        public virtual DbSet<Outingtransport> Outingtransports { get; set; } = null!;
        public virtual DbSet<Person> Persons { get; set; } = null!;
        public virtual DbSet<Position> Positions { get; set; } = null!;
        public virtual DbSet<Requestbike> Requestbikes { get; set; } = null!;
        public virtual DbSet<Requestpassanger> Requestpassangers { get; set; } = null!;
        public virtual DbSet<Treasurer> Treasurers { get; set; } = null!;
        public virtual DbSet<Vehicle> Vehicles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.; Database=CYCLINGCLUB; trusted_connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bycicle>(entity =>
            {
                entity.HasKey(e => e.Idbycicle)
                    .HasName("PK__bycicle__1DB8E0FE293E1298");

                entity.ToTable("bycicle");

                entity.Property(e => e.Idbycicle)
                    .ValueGeneratedNever()
                    .HasColumnName("idbycicle");

                entity.Property(e => e.Column1).HasColumnName("column1");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.Owner)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("owner");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.HasKey(e => e.Date)
                    .HasName("PK__calendar__D9DE21FC4F09F18B");

                entity.ToTable("calendar");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Categorie).HasColumnName("categorie");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("category");

                entity.Property(e => e.Idcategory).HasColumnName("idcategory");

                entity.Property(e => e.Manager).HasColumnName("manager");

                entity.Property(e => e.Namecat)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("namecat");
            });

            modelBuilder.Entity<Enrollment>(entity =>
            {
                entity.HasKey(e => new { e.Category, e.Member })
                    .HasName("PK__enrollme__3BE93F1E627C3204");

                entity.ToTable("enrollments");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Member).HasColumnName("member");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Fee>(entity =>
            {
                entity.HasKey(e => e.Idfees);

                entity.Property(e => e.Idfees).HasColumnName("idfees");

                entity.Property(e => e.Dateisuefees)
                    .HasColumnType("date")
                    .HasColumnName("dateisuefees");

                entity.Property(e => e.Namefees)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("namefees");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.HasKey(e => e.Idmanager)
                    .HasName("PK__manager__07D44381805A2C2A");

                entity.ToTable("manager");

                entity.Property(e => e.Idmanager)
                    .ValueGeneratedNever()
                    .HasColumnName("idmanager");

                entity.Property(e => e.Mail)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("mail");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.ToTable("member");

                entity.Property(e => e.Memberid)
                    .ValueGeneratedNever()
                    .HasColumnName("memberid");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.Mail)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mail");
            });

            modelBuilder.Entity<Outing>(entity =>
            {
                entity.HasKey(e => e.Idouting)
                    .HasName("PK__outing__FD002236040A136C");

                entity.ToTable("outing");

                entity.Property(e => e.Idouting)
                    .ValueGeneratedNever()
                    .HasColumnName("idouting");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.Startingpoint)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("startingpoint");
            });

            modelBuilder.Entity<Outingregistration>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("outingregistration");

                entity.Property(e => e.Bike).HasColumnName("bike");

                entity.Property(e => e.Memberid).HasColumnName("memberid");

                entity.Property(e => e.Outingid).HasColumnName("outingid");

                entity.Property(e => e.Passanger).HasColumnName("passanger");
            });

            modelBuilder.Entity<Outingtransport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("outingtransport");

                entity.Property(e => e.Outingid).HasColumnName("outingid");

                entity.Property(e => e.Outingtransportnumber).HasColumnName("outingtransportnumber");

                entity.Property(e => e.Platenumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("platenumber");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.Mail)
                    .HasName("PK__person__7A2129055425C4EB");

                entity.ToTable("person");

                entity.Property(e => e.Mail)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("firstname");

                entity.Property(e => e.Password)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Pos).HasColumnName("pos");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("position");

                entity.Property(e => e.Idpos).HasColumnName("idpos");

                entity.Property(e => e.Namepos)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("namepos");
            });

            modelBuilder.Entity<Requestbike>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("requestbike");

                entity.Property(e => e.Bikeid).HasColumnName("bikeid");

                entity.Property(e => e.Platenumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("platenumber");
            });

            modelBuilder.Entity<Requestpassanger>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("requestpassanger");

                entity.Property(e => e.Memberid).HasColumnName("memberid");

                entity.Property(e => e.Platenumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("platenumber");
            });

            modelBuilder.Entity<Treasurer>(entity =>
            {
                entity.HasKey(e => e.Idtreasurer)
                    .HasName("PK__treasure__C2A73A719A26AB2A");

                entity.ToTable("treasurer");

                entity.Property(e => e.Idtreasurer)
                    .ValueGeneratedNever()
                    .HasColumnName("idtreasurer");

                entity.Property(e => e.Mail)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("mail");
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.HasKey(e => e.Platenumber)
                    .HasName("PK__vehicle__592496B771F98299");

                entity.ToTable("vehicle");

                entity.Property(e => e.Platenumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("platenumber");

                entity.Property(e => e.Extrabikespace).HasColumnName("extrabikespace");

                entity.Property(e => e.Owner).HasColumnName("owner");

                entity.Property(e => e.Passangerseat).HasColumnName("passangerseat");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
