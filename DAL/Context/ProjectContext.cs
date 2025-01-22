using DAL.Configurations;
using DAL.Configurations.Films;
using DAL.Configurations.Orders;
using DAL.Configurations.Suppliers;
using DAL.Configurations.Users;
using DAL.FakeData;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MODEL.Entities.FilmEntities;
using MODEL.Entities.OrderEntities;
using MODEL.Entities.SupplierEntities;
using MODEL.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class ProjectContext: IdentityDbContext<User>
    {
        //constructor
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {

        }
        public ProjectContext()
        {

        }

        #region DBSet

        //Film Tabloları

        public DbSet<Film> Films { get; set; }
        public DbSet<FaultyFilm> FaultyFilms { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SpecialCategory> SpecialCategories { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        public DbSet<Comment> Comments { get; set; }        

        public DbSet<Award> Awards { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Director> Directors { get; set; }

        public DbSet<CategoryFilm> CategoryFilms { get; set; }
        public DbSet<FilmArtist> FilmArtists { get; set; }

        public DbSet<FilmDirector> FilmDirectors { get; set; }

        //User Tabloları
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<UserWatchList> UserWatchLists { get; set; }

        public DbSet<UserFilmRental> UserFilmRentals { get; set; }

        public DbSet<Notification> Notifications { get; set; }
        public DbSet<UserFilmList> UserFilmLists { get; set; }


        //Order Tabloları
       
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }

        public DbSet<Courier> Couriers { get; set; }
        public DbSet<DeliveryPlan> DeliveryPlans { get; set; }
        
        //Supplier Tabloları

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierFilm> SupplierFilms { get; set; }
        public DbSet<Payment> Payments { get; set; }











        #endregion

        #region ConnectionString 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured) optionsBuilder.UseSqlServer("server=DESKTOP-P8K1SK9;database=FinalProjectMovie;Trusted_Connection=true;TrustServerCertificate=True");

            base.OnConfiguring(optionsBuilder);
        }

        #endregion

        #region Customize Entities

        protected override void OnModelCreating(ModelBuilder builder)
        {

            FilmFaker.Initialize(30, 3);
            //Film Configurations
            builder.ApplyConfiguration(new FilmConfiguration());

            builder.ApplyConfiguration(new FaultyFilmConfiguration());

            builder.ApplyConfiguration(new InventoryConfiguration());

            builder.ApplyConfiguration(new CategoryConfiguration());

            builder.ApplyConfiguration(new SpecialFilmCategoryConfiguration());

            builder.ApplyConfiguration(new RatingConfiguration());

            builder.ApplyConfiguration(new CommentConfiguration());

            builder.ApplyConfiguration(new ArtistConfiguration());

            builder.ApplyConfiguration(new DirectorConfiguration());

            builder.ApplyConfiguration(new CategoryFilmConfiguration());

            builder.ApplyConfiguration(new FilmArtistConfiguration());

            builder.ApplyConfiguration(new FilmDirectorConfiguration());

            //User Configurations
            builder.ApplyConfiguration(new UserConfiguration());

            builder.ApplyConfiguration(new UserFilmListConfiguration());

            builder.ApplyConfiguration(new MembershipConfiguration());


            builder.ApplyConfiguration(new UserWatchListConfiguration());

            builder.ApplyConfiguration(new UserFilmRentalConfiguration());

            builder.ApplyConfiguration(new NotificationConfiguration());

            builder.ApplyConfiguration(new UserFilmListConfiguration());

            //Order Configurations
            builder.ApplyConfiguration(new OrderConfiguration());

            builder.ApplyConfiguration(new OrderDetailConfiguration());

            builder.ApplyConfiguration(new DeliveryConfiguration());

            builder.ApplyConfiguration(new CourierConfiguration());

            builder.ApplyConfiguration(new DeliveryPlanConfiguration());

            //Supplier Configurations
            builder.ApplyConfiguration(new SupplierConfiguration());

            builder.ApplyConfiguration(new SupplierFilmConfiguration());

            builder.ApplyConfiguration(new PaymentConfiguration());

            base.OnModelCreating(builder);
        }

        #endregion




    }
}
