using System.ComponentModel.DataAnnotations.Schema;

namespace Cartalog.Data.Entities
{
    /// <summary>
    /// Class Tune.
    /// Implements the <see cref="Cartalog.Data.Entities.EntityBase" />
    /// </summary>
    /// <seealso cref="Cartalog.Data.Entities.EntityBase" />
    public class Tune : EntityBase
    {
        /// <summary>
        /// Gets or sets the car identifier.
        /// </summary>
        /// <value>The car identifier.</value>
        public Guid CarId { get; set; }

        /// <summary>
        /// Gets or sets the car.
        /// </summary>
        /// <value>The car.</value>
        [ForeignKey(nameof(CarId))]
        public Car Car { get; set; }

        /// <summary>
        /// Gets or sets the game identifier.
        /// </summary>
        /// <value>The game identifier.</value>
        public Guid GameId { get; set; }

        /// <summary>
        /// Gets or sets the game.
        /// </summary>
        /// <value>The game.</value>
        [ForeignKey(nameof(GameId))]
        public Game Game { get; set; }

        /// <summary>
        /// Gets or sets the route identifier.
        /// </summary>
        /// <value>The route identifier.</value>
        public Guid? RouteId { get; set; }

        /// <summary>
        /// Gets or sets the route.
        /// </summary>
        /// <value>The route.</value>
        [ForeignKey(nameof(RouteId))]
        public Route Route { get; set; }

        /// <summary>
        /// Gets or sets the upgrades.
        /// </summary>
        /// <value>The upgrades.</value>
        public ICollection<TuneUpgrade> Upgrades { get; set; }
        /// <summary>
        /// Gets or sets the settings.
        /// </summary>
        /// <value>The settings.</value>
        public ICollection<TuneSetting> Settings { get; set; }
    }
}