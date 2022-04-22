#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HoangMaiCongDat.Models;

namespace HoangMaiCongDat.Data
{
    public class HoangMaiCongDatContext : DbContext
    {
        public HoangMaiCongDatContext (DbContextOptions<HoangMaiCongDatContext> options)
            : base(options)
        {
        }

        public DbSet<HoangMaiCongDat.Models.Category> Category { get; set; }

        public DbSet<HoangMaiCongDat.Models.News> News { get; set; }

        public DbSet<HoangMaiCongDat.Models.Comment> Comment { get; set; }
    }
}
