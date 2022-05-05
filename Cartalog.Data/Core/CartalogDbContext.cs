using Cartalog.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cartalog.Data.Core
{
    public class CartalogDbContext : DbContext
    {
        public CartalogDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SurfaceType> SurfaceTypes { get; set; }
        public DbSet<Tune> Tunes { get; set; }
        public DbSet<TuneSetting> TuneSettings { get; set; }
        public DbSet<TuneUpgrade> TuneUpgrades { get; set; }
        public DbSet<Upgrade> Upgrades { get; set; }
    }
}