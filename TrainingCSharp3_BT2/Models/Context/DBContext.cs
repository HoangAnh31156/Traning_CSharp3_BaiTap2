using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TrainingCSharp3_BT2.Models.DomainClass;

namespace TrainingCSharp3_BT2.Models.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ban> Bans { get; set; }

    public virtual DbSet<ChucVu> ChucVus { get; set; }

    public virtual DbSet<LoaiSp> LoaiSps { get; set; }

    public virtual DbSet<LoaiXm> LoaiXms { get; set; }

    public virtual DbSet<MoiQuanHe> MoiQuanHes { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<Nxb> Nxbs { get; set; }

    public virtual DbSet<Sach> Saches { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<XeMay> XeMays { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-B52SRBN\\SQLEXPRESS;Initial Catalog=FINALASS_FPOLY_NET_JAVA_SM22_BL2;Integrated Security=True; TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ban>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ban__3214EC0740D02CD5");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.GioiTinh).HasDefaultValueSql("((0))");
            entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.IdMqhNavigation).WithMany(p => p.Bans).HasConstraintName("FK1_MQH");
        });

        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ChucVu__3214EC07B32835F0");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<LoaiSp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LoaiSP__3214EC07EDAAE99F");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<LoaiXm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LoaiXM__3214EC0708B1366A");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<MoiQuanHe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MoiQuanH__3214EC074A42AAD4");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NhanVien__3214EC07C2B289B5");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.IdCvNavigation).WithMany(p => p.NhanViens).HasConstraintName("FK1_NV");
        });

        modelBuilder.Entity<Nxb>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NXB__3214EC07AE5D17C5");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<Sach>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sach__3214EC07D42237C4");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DonGia).HasDefaultValueSql("((0))");
            entity.Property(e => e.SoTrang).HasDefaultValueSql("((0))");
            entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.IdNxbNavigation).WithMany(p => p.Saches).HasConstraintName("FK1_NXB");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SanPham__3214EC07724D0453");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.GiaBan).HasDefaultValueSql("((0))");
            entity.Property(e => e.SoLuong).HasDefaultValueSql("((0))");
            entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.IdLoaiSpNavigation).WithMany(p => p.SanPhams).HasConstraintName("FK1_LSP");
        });

        modelBuilder.Entity<XeMay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__XeMay__3214EC0715E4DEDC");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.GiaBan).HasDefaultValueSql("((0))");
            entity.Property(e => e.GiaNhap).HasDefaultValueSql("((0))");
            entity.Property(e => e.SoLuong).HasDefaultValueSql("((0))");
            entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.IdLxmNavigation).WithMany(p => p.XeMays).HasConstraintName("FK1_LXM");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
