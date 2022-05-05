using Cartalog.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cartalog.Data.Core
{
    /// <summary>
    /// Class CartalogDbContext.
    /// Implements the <see cref="DbContext" />
    /// </summary>
    /// <seealso cref="DbContext" />
    public class CartalogDbContext : DbContext
    {
        /// <summary>
        /// Gets or sets the brands.
        /// </summary>
        /// <value>The brands.</value>
        public DbSet<Brand> Brands { get; set; }

        /// <summary>
        /// Gets or sets the cars.
        /// </summary>
        /// <value>The cars.</value>
        public DbSet<Car> Cars { get; set; }

        /// <summary>
        /// Gets or sets the games.
        /// </summary>
        /// <value>The games.</value>
        public DbSet<Game> Games { get; set; }

        /// <summary>
        /// Gets or sets the platforms.
        /// </summary>
        /// <value>The platforms.</value>
        public DbSet<Platform> Platforms { get; set; }

        /// <summary>
        /// Gets or sets the records.
        /// </summary>
        /// <value>The records.</value>
        public DbSet<Record> Records { get; set; }

        /// <summary>
        /// Gets or sets the routes.
        /// </summary>
        /// <value>The routes.</value>
        public DbSet<Route> Routes { get; set; }

        /// <summary>
        /// Gets or sets the settings.
        /// </summary>
        /// <value>The settings.</value>
        public DbSet<Setting> Settings { get; set; }

        /// <summary>
        /// Gets or sets the surface types.
        /// </summary>
        /// <value>The surface types.</value>
        public DbSet<SurfaceType> SurfaceTypes { get; set; }

        /// <summary>
        /// Gets or sets the tunes.
        /// </summary>
        /// <value>The tunes.</value>
        public DbSet<Tune> Tunes { get; set; }

        /// <summary>
        /// Gets or sets the tune settings.
        /// </summary>
        /// <value>The tune settings.</value>
        public DbSet<TuneSetting> TuneSettings { get; set; }

        /// <summary>
        /// Gets or sets the tune upgrades.
        /// </summary>
        /// <value>The tune upgrades.</value>
        public DbSet<TuneUpgrade> TuneUpgrades { get; set; }

        /// <summary>
        /// Gets or sets the upgrades.
        /// </summary>
        /// <value>The upgrades.</value>
        public DbSet<Upgrade> Upgrades { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CartalogDbContext" /> class.
        /// </summary>
        /// <param name="options">The options for this context.</param>
        /// <remarks>See <see href="https://aka.ms/efcore-docs-dbcontext">DbContext lifetime, configuration, and initialization</see> and
        /// <see href="https://aka.ms/efcore-docs-dbcontext-options">Using DbContextOptions</see> for more information.</remarks>
        public CartalogDbContext(DbContextOptions options) : base(options)
        { }
    }
}