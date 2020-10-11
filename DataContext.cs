using Microsoft.EntityFrameworkCore;

namespace Tourism.Model
{
    public class DataContext:DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Package> packages { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = "Data Source=K-S-K\\SQLEXPRESS01;Initial Catalog=Project;Integrated Security = true";
            optionsBuilder.UseSqlServer(conn);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Booking>().HasOne(b => b.UserRole).WithMany(b => b.Bookings).HasForeignKey(b => b.UserRoleId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Booking>().HasOne(b => b.package).WithMany(b => b.Bookings).HasForeignKey(b => b.PackageId).OnDelete(DeleteBehavior.NoAction);



            modelBuilder.Entity<User>().Property(b => b.FirstName).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.LastName).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Email).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Mobile).HasColumnType("varchar(20)").IsRequired();
           // modelBuilder.Entity<User>().Property(b => b.DateOfBirth).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Gender).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Password).HasColumnType("varchar(20)").IsRequired();
            modelBuilder.Entity<User>().Property(b => b.Pincode).HasColumnType("varchar(6)").IsRequired();


            modelBuilder.Entity<Role>().Property(b => b.Name).HasColumnType("varchar(200)").IsRequired();

            modelBuilder.Entity<Booking>().Property(b => b.PackageAmount).HasColumnName("decimal(14,2)").IsRequired();
           // modelBuilder.Entity<Booking>().Property(b => b.StartDate).HasColumnType("datetime2(3)").IsRequired();
           // modelBuilder.Entity<Booking>().Property(b => b.EndDate).HasColumnType("datetime2(3)").IsRequired();
            modelBuilder.Entity<Booking>().Property(b => b.BookingAmount).HasColumnType("Decimal(14,2)").IsRequired();
            modelBuilder.Entity<Booking>().Property(b => b.Discount).HasColumnType("Decimal(14,2)").IsRequired();
            modelBuilder.Entity<Booking>().Property(b => b.GrossAmount).HasColumnType("Decimal(14,2)").IsRequired();
            modelBuilder.Entity<Booking>().Property(b => b.GST).HasColumnType("Decimal(14,2)").IsRequired();
            modelBuilder.Entity<Booking>().Property(b => b.NetAmount).HasColumnType("Decimal(14,2)").IsRequired();
            modelBuilder.Entity<Booking>().Property(b => b.TotalPaid).HasColumnType("Decimal(14,2)").IsRequired();
            modelBuilder.Entity<Booking>().Property(b => b.BalanceAmount).HasColumnType("Decimal(14,2)").IsRequired();
            modelBuilder.Entity<Booking>().Property(b => b.Status).HasColumnType("varchar(20)").IsRequired();
            //modelBuilder.Entity<Booking>().Property(b => b.BookingLastDate).HasColumnType("datetime2(3)").IsRequired();
            
            modelBuilder.Entity<Package>().Property(b => b.Name).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Package>().Property(b => b.Type).HasColumnType("varchar(200)").IsRequired();
            modelBuilder.Entity<Package>().Property(b => b.Destination).HasColumnType("varchar(200)").IsRequired();
           // modelBuilder.Entity<Package>().Property(b => b.NoOfAdults).HasColumnType("int(200)").IsRequired();
            //modelBuilder.Entity<Package>().Property(b => b.NoOfChild).HasColumnType("int(200)").IsRequired();

            modelBuilder.Entity<Payment>().Property(b => b.Amount).HasColumnType("Decimal(14,2)").IsRequired();
            //modelBuilder.Entity<Payment>().Property(b => b.Date).HasColumnType("datetime2(3)").IsRequired();
            modelBuilder.Entity<Payment>().Property(b => b.Status).HasColumnType("varchar(20)").IsRequired();


            //Practice for table name change-->
            //modelBuilder.Entity<User>().ToTable("bologs");

            //Practice for change the column name-->
            //modelBuilder.Entity<User>().Property(b => b.FirstName).HasColumnName("First Name");


        }
    }
}
