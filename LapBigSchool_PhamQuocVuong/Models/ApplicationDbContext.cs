﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace LapBigSchool_PhamQuocVuong.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public static implicit operator ApplicationContext(ApplicationDbContext v)
        {
            throw new NotImplementedException();
        }
    }
}