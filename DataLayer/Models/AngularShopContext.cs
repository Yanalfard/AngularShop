using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataLayer.Models
{
    public partial class AngularShopContext : DbContext
    {
        public AngularShopContext()
        {
        }

        public AngularShopContext(DbContextOptions<AngularShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAboutU> TblAboutUs { get; set; }
        public virtual DbSet<TblAddress> TblAddresses { get; set; }
        public virtual DbSet<TblAmount> TblAmounts { get; set; }
        public virtual DbSet<TblBannerAndSlide> TblBannerAndSlides { get; set; }
        public virtual DbSet<TblBlog> TblBlogs { get; set; }
        public virtual DbSet<TblBlogCommentRel> TblBlogCommentRels { get; set; }
        public virtual DbSet<TblBlogKeywordRel> TblBlogKeywordRels { get; set; }
        public virtual DbSet<TblBookMark> TblBookMarks { get; set; }
        public virtual DbSet<TblCatagory> TblCatagories { get; set; }
        public virtual DbSet<TblClient> TblClients { get; set; }
        public virtual DbSet<TblColor> TblColors { get; set; }
        public virtual DbSet<TblComment> TblComments { get; set; }
        public virtual DbSet<TblConfig> TblConfigs { get; set; }
        public virtual DbSet<TblContactForm> TblContactForms { get; set; }
        public virtual DbSet<TblContactU> TblContactUs { get; set; }
        public virtual DbSet<TblDiscount> TblDiscounts { get; set; }
        public virtual DbSet<TblImage> TblImages { get; set; }
        public virtual DbSet<TblKeyword> TblKeywords { get; set; }
        public virtual DbSet<TblOrder> TblOrders { get; set; }
        public virtual DbSet<TblOrderDetail> TblOrderDetails { get; set; }
        public virtual DbSet<TblPostOption> TblPostOptions { get; set; }
        public virtual DbSet<TblProduct> TblProducts { get; set; }
        public virtual DbSet<TblProductCommentRel> TblProductCommentRels { get; set; }
        public virtual DbSet<TblProductImageRel> TblProductImageRels { get; set; }
        public virtual DbSet<TblProductKeywordRel> TblProductKeywordRels { get; set; }
        public virtual DbSet<TblProductPropertyRel> TblProductPropertyRels { get; set; }
        public virtual DbSet<TblProperty> TblProperties { get; set; }
        public virtual DbSet<TblRate> TblRates { get; set; }
        public virtual DbSet<TblRegularQuestion> TblRegularQuestions { get; set; }
        public virtual DbSet<TblRole> TblRoles { get; set; }
        public virtual DbSet<TblSize> TblSizes { get; set; }
        public virtual DbSet<TblSpecialOffer> TblSpecialOffers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=103.216.62.27;Initial Catalog=AngularShop;User ID=Yanal;Password=1710ahmad.fard");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblAddress>(entity =>
            {
                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblAddresses)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TblAddress_TblClient");
            });

            modelBuilder.Entity<TblAmount>(entity =>
            {
                entity.Property(e => e.PriceBeforeDiscount).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.TblAmounts)
                    .HasForeignKey(d => d.ColorId)
                    .HasConstraintName("FK_TblAmount_TblColor");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblAmounts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_TblAmount_TblProduct");

                entity.HasOne(d => d.Size)
                    .WithMany(p => p.TblAmounts)
                    .HasForeignKey(d => d.SizeId)
                    .HasConstraintName("FK_TblAmount_TblSize");
            });

            modelBuilder.Entity<TblBlog>(entity =>
            {
                entity.Property(e => e.DateCreated).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblBlogCommentRel>(entity =>
            {
                entity.HasOne(d => d.Blog)
                    .WithMany(p => p.TblBlogCommentRels)
                    .HasForeignKey(d => d.BlogId)
                    .HasConstraintName("FK_TblBlogCommentRel_TblBlog");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.TblBlogCommentRels)
                    .HasForeignKey(d => d.CommentId)
                    .HasConstraintName("FK_TblBlogCommentRel_TblComment");
            });

            modelBuilder.Entity<TblBlogKeywordRel>(entity =>
            {
                entity.HasOne(d => d.Blog)
                    .WithMany(p => p.TblBlogKeywordRels)
                    .HasForeignKey(d => d.BlogId)
                    .HasConstraintName("FK_TblBlogKeywordRel_TblBlog");

                entity.HasOne(d => d.Keyword)
                    .WithMany(p => p.TblBlogKeywordRels)
                    .HasForeignKey(d => d.KeywordId)
                    .HasConstraintName("FK_TblBlogKeywordRel_TblKeyword");
            });

            modelBuilder.Entity<TblBookMark>(entity =>
            {
                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblBookMarks)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_TblBookMark_TblClient");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblBookMarks)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_TblBookMark_TblProduct");
            });

            modelBuilder.Entity<TblCatagory>(entity =>
            {
                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_TblCatagory_TblCatagory");
            });

            modelBuilder.Entity<TblClient>(entity =>
            {
                entity.Property(e => e.DateCreated).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TblClients)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TblClient_TblRole");
            });

            modelBuilder.Entity<TblColor>(entity =>
            {
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblColors)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_TblColor_TblProduct");
            });

            modelBuilder.Entity<TblComment>(entity =>
            {
                entity.Property(e => e.DateCreated).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblComments)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TblComment_TblClient");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_TblComment_TblComment");
            });

            modelBuilder.Entity<TblKeyword>(entity =>
            {
                entity.HasKey(e => e.KeywordId)
                    .HasName("PK_TblKeywords");
            });

            modelBuilder.Entity<TblOrder>(entity =>
            {
                entity.HasKey(e => e.OrdeId)
                    .HasName("PK_TblOrder_1");

                entity.Property(e => e.DateSubmited).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SendPrice).HasComment("0");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.TblOrders)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TblOrder_TblAddress");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblOrders)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TblOrder_TblClient1");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.TblOrders)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("FK_TblOrder_TblDiscount");
            });

            modelBuilder.Entity<TblOrderDetail>(entity =>
            {
                entity.HasKey(e => e.OrderDetailId)
                    .HasName("PK_TblClientProductRel");

                entity.Property(e => e.Count).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Amount)
                    .WithMany(p => p.TblOrderDetails)
                    .HasForeignKey(d => d.AmountId)
                    .HasConstraintName("FK_TblOrderDetail_TblAmount");

                entity.HasOne(d => d.FinalOrder)
                    .WithMany(p => p.TblOrderDetails)
                    .HasForeignKey(d => d.FinalOrderId)
                    .HasConstraintName("FK_TblOrderDetail_TblOrder");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblOrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TblOrderDetail_TblProduct");
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.Property(e => e.DateCreated).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Catagory)
                    .WithMany(p => p.TblProducts)
                    .HasForeignKey(d => d.CatagoryId)
                    .HasConstraintName("FK_TblProduct_TblCatagory");
            });

            modelBuilder.Entity<TblProductCommentRel>(entity =>
            {
                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.TblProductCommentRels)
                    .HasForeignKey(d => d.CommentId)
                    .HasConstraintName("FK_TblProductCommentRel_TblComment");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblProductCommentRels)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_TblProductCommentRel_TblProduct");
            });

            modelBuilder.Entity<TblProductImageRel>(entity =>
            {
                entity.HasOne(d => d.Image)
                    .WithMany(p => p.TblProductImageRels)
                    .HasForeignKey(d => d.ImageId)
                    .HasConstraintName("FK_TblProductImageRel_TblImage");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblProductImageRels)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_TblProductImageRel_TblProduct");
            });

            modelBuilder.Entity<TblProductKeywordRel>(entity =>
            {
                entity.HasOne(d => d.Keyword)
                    .WithMany(p => p.TblProductKeywordRels)
                    .HasForeignKey(d => d.KeywordId)
                    .HasConstraintName("FK_TblProductKeywordRel_TblKeywords");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblProductKeywordRels)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_TblProductKeywordRel_TblProduct");
            });

            modelBuilder.Entity<TblProductPropertyRel>(entity =>
            {
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblProductPropertyRels)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_TblProductPropertyRel_TblProduct");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.TblProductPropertyRels)
                    .HasForeignKey(d => d.PropertyId)
                    .HasConstraintName("FK_TblProductPropertyRel_TblProperty");
            });

            modelBuilder.Entity<TblRate>(entity =>
            {
                entity.HasOne(d => d.Client)
                    .WithMany(p => p.TblRates)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_TblRate_TblClient");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblRates)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TblRate_TblProduct");
            });

            modelBuilder.Entity<TblRole>(entity =>
            {
                entity.Property(e => e.RoleId).ValueGeneratedNever();

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<TblSize>(entity =>
            {
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblSizes)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_TblSize_TblProduct");
            });

            modelBuilder.Entity<TblSpecialOffer>(entity =>
            {
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TblSpecialOffers)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_TblSpecialOffer_TblProduct");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
