﻿using Microsoft.EntityFrameworkCore;
using tett1.Areas.Admin.Models;

namespace tett1.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        { }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Post> Posts { get; set; }

        public DbSet<view_Post_Menu> PostMenus { get; set; }
        public DbSet<AdminMenu> AdminMenus { get; set; }
    }
}
