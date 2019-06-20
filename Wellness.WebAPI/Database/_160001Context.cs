using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Wellness.WebAPI.Database
{
    public partial class _160001Context : DbContext
    {
        public _160001Context()
        {
        }

        public _160001Context(DbContextOptions<_160001Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Clan> Clan { get; set; }
        public virtual DbSet<ClanPrisustvo> ClanPrisustvo { get; set; }
        public virtual DbSet<Clanarina> Clanarina { get; set; }
        public virtual DbSet<Grad> Grad { get; set; }
        public virtual DbSet<Osoba> Osoba { get; set; }
        public virtual DbSet<Paket> Paket { get; set; }
        public virtual DbSet<Radnik> Radnik { get; set; }
        public virtual DbSet<RadnikPlataHistorija> RadnikPlataHistorija { get; set; }
        public virtual DbSet<TipTreninga> TipTreninga { get; set; }
        public virtual DbSet<Trener> Trener { get; set; }
        public virtual DbSet<Trening> Trening { get; set; }
        public virtual DbSet<Uloga> Uloga { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=160001;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Clan>(entity =>
            {
                entity.Property(e => e.DatumRegistracije).HasColumnType("date");

                entity.HasOne(d => d.Osoba)
                    .WithMany(p => p.Clan)
                    .HasForeignKey(d => d.OsobaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Clan__OsobaId__4D94879B");
            });

            modelBuilder.Entity<ClanPrisustvo>(entity =>
            {
                entity.Property(e => e.DatumPrijave).HasColumnType("datetime");

                entity.HasOne(d => d.Clan)
                    .WithMany(p => p.ClanPrisustvo)
                    .HasForeignKey(d => d.ClanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ClanPrisu__ClanI__160F4887");

                entity.HasOne(d => d.Trening)
                    .WithMany(p => p.ClanPrisustvo)
                    .HasForeignKey(d => d.TreningId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ClanPrisu__Treni__151B244E");
            });

            modelBuilder.Entity<Clanarina>(entity =>
            {
                entity.Property(e => e.DatumUplate).HasColumnType("date");

                entity.Property(e => e.IznosUplate).HasColumnType("money");

                entity.HasOne(d => d.Clan)
                    .WithMany(p => p.Clanarina)
                    .HasForeignKey(d => d.ClanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Clanarina__ClanI__52593CB8");

                entity.HasOne(d => d.Paket)
                    .WithMany(p => p.Clanarina)
                    .HasForeignKey(d => d.PaketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Clanarina__Paket__534D60F1");
            });

            modelBuilder.Entity<Grad>(entity =>
            {
                entity.Property(e => e.Grad1)
                    .IsRequired()
                    .HasColumnName("Grad")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Osoba>(entity =>
            {
                entity.Property(e => e.BrojTelefona)
                    .HasColumnName("Broj_Telefona")
                    .HasMaxLength(16);

                entity.Property(e => e.DatumRodenja)
                    .HasColumnName("Datum_Rodenja")
                    .HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(64);

                entity.Property(e => e.Ime).HasMaxLength(32);

                entity.Property(e => e.Jmbg)
                    .HasColumnName("JMBG")
                    .HasMaxLength(13);

                entity.Property(e => e.KorisnickoIme).HasMaxLength(32);

                entity.Property(e => e.LozinkaHash).HasMaxLength(256);

                entity.Property(e => e.LozinkaSalt).HasMaxLength(256);

                entity.Property(e => e.Prezime).HasMaxLength(32);

                entity.Property(e => e.Spol).HasMaxLength(1);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Osoba)
                    .HasForeignKey(d => d.GradId)
                    .HasConstraintName("FK__Osoba__GradId__5441852A");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.Osoba)
                    .HasForeignKey(d => d.UlogaId)
                    .HasConstraintName("FK__Osoba__UlogaId__02FC7413");
            });

            modelBuilder.Entity<Paket>(entity =>
            {
                entity.Property(e => e.Cijena).HasColumnType("money");

                entity.Property(e => e.Naziv).HasMaxLength(64);

                entity.Property(e => e.Opis).HasMaxLength(2048);
            });

            modelBuilder.Entity<Radnik>(entity =>
            {
                entity.Property(e => e.DatumZaposlenja).HasColumnType("date");

                entity.Property(e => e.Satnica).HasColumnType("money");

                entity.HasOne(d => d.Osoba)
                    .WithMany(p => p.Radnik)
                    .HasForeignKey(d => d.OsobaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Radnik__OsobaId__5070F446");
            });

            modelBuilder.Entity<RadnikPlataHistorija>(entity =>
            {
                entity.HasKey(e => new { e.UplataZaGodinu, e.UplataZaMjesec, e.RadnikId })
                    .HasName("PK_RadnikPlataHistorija_P");

                entity.Property(e => e.DatumUplate).HasColumnType("date");

                entity.Property(e => e.Satnica).HasColumnType("money");

                entity.HasOne(d => d.Radnik)
                    .WithMany(p => p.RadnikPlataHistorija)
                    .HasForeignKey(d => d.RadnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__RadnikPla__Radni__5165187F");
            });

            modelBuilder.Entity<TipTreninga>(entity =>
            {
                entity.Property(e => e.Opis).HasMaxLength(256);

                entity.Property(e => e.TipTreninga1)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Trener>(entity =>
            {
                entity.Property(e => e.Specializacija).HasMaxLength(64);

                entity.HasOne(d => d.Radnik)
                    .WithMany(p => p.Trener)
                    .HasForeignKey(d => d.RadnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Trener__RadnikId__4CA06362");
            });

            modelBuilder.Entity<Trening>(entity =>
            {
                entity.Property(e => e.DatumTreninga).HasColumnType("date");

                entity.Property(e => e.VrijemeKraj).HasColumnType("datetime");

                entity.Property(e => e.VrijemePocetak).HasColumnType("datetime");

                entity.HasOne(d => d.TipTreninga)
                    .WithMany(p => p.Trening)
                    .HasForeignKey(d => d.TipTreningaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Trening__TipTren__4BAC3F29");

                entity.HasOne(d => d.Trener)
                    .WithMany(p => p.Trening)
                    .HasForeignKey(d => d.TrenerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Trening__TrenerI__4AB81AF0");
            });

            modelBuilder.Entity<Uloga>(entity =>
            {
                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Opis).HasMaxLength(256);
            });
        }
    }
}
