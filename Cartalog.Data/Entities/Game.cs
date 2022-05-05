namespace Cartalog.Data.Entities
{
    /// <summary>
    /// Class Game.
    /// Implements the <see cref="Cartalog.Data.Entities.EntityBase" />
    /// </summary>
    /// <seealso cref="Cartalog.Data.Entities.EntityBase" />
    public class Game : EntityBase
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the cars.
        /// </summary>
        /// <value>The cars.</value>
        public ICollection<Car> Cars { get; set; }
        /// <summary>
        /// Gets or sets the routes.
        /// </summary>
        /// <value>The routes.</value>
        public ICollection<Route> Routes { get; set; }
        /// <summary>
        /// Gets or sets the platforms.
        /// </summary>
        /// <value>The platforms.</value>
        public ICollection<Platform> Platforms { get; set; }
        /// <summary>
        /// Gets or sets the upgrades.
        /// </summary>
        /// <value>The upgrades.</value>
        public ICollection<Upgrade> Upgrades { get; set; }
    }
}