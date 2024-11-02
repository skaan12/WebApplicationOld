using DAL.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class ProjectContext: IdentityDbContext<User>
    {
        //const

        #region DBSet
        public DbSet<Delivery> Deliveries {  get; set; }

        public DbSet<FaultyFilm> FaultyFilms { get; set; }

        public DbSet<Film> Films { get; set; }

        public DbSet<Membership> Memberships { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<UserFilmList> UserFilmLists { get; set; }


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
            builder.ApplyConfiguration(new DeliveryConfiguration());

            builder.ApplyConfiguration(new  FaultyFilmConfiguration()); 

            builder.ApplyConfiguration(new FilmConfiguration());

            builder.ApplyConfiguration(new MembershipConfiguration());

            builder.ApplyConfiguration(new OrderConfiguration());

            builder.ApplyConfiguration(new OrderDetailConfiguration());

            builder.ApplyConfiguration(new UserConfiguration());

            builder.ApplyConfiguration(new UserFilmListConfiguration());


            base.OnModelCreating(builder);
        }

        #endregion




    }
}
