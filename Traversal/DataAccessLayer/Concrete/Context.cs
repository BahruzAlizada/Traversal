﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= DESKTOP-OK3QKVJ;database=Travelsal;Integrated Security=true");
        }

        public SubAbout FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Team> Teams { get;set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<ContactForm> ContactForms { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<DestinationDetail> DestinationDetails { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
    }
}
