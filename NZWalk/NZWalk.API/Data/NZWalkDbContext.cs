using Microsoft.EntityFrameworkCore;
using NZWalk.API.Models.Domain;

namespace NZWalk.API.Data
{
    public class NZWalkDbContext :DbContext
    {
        public NZWalkDbContext(DbContextOptions<NZWalkDbContext> options) : base(options)
        {

        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WWalkDifficulty { get; set; }
    }
}
