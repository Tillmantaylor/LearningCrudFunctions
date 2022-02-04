using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TVTLabW03Crud.Models.Entities;

namespace TVTLabW03Crud.Services
{
    public class VideoGameDbContext : DbContext
    {
        public VideoGameDbContext(DbContextOptions options) : base(options) { }
        public DbSet<VideoGame> VideoGames { get; set; }
    }

}
