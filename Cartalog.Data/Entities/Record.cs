using System.ComponentModel.DataAnnotations.Schema;

namespace Cartalog.Data.Entities
{
    /// <summary>
    /// Class Record.
    /// Implements the <see cref="Cartalog.Data.Entities.EntityBase" />
    /// </summary>
    /// <seealso cref="Cartalog.Data.Entities.EntityBase" />
    public class Record : EntityBase
    {
        /// <summary>
        /// Gets or sets the tune identifier.
        /// </summary>
        /// <value>The tune identifier.</value>
        public Guid TuneId { get; set; }

        /// <summary>
        /// Gets or sets the tune.
        /// </summary>
        /// <value>The tune.</value>
        [ForeignKey(nameof(TuneId))]
        public Tune Tune { get; set; }

        /// <summary>
        /// Gets or sets the route identifier.
        /// </summary>
        /// <value>The route identifier.</value>
        public Guid RouteId { get; set; }

        /// <summary>
        /// Gets or sets the route.
        /// </summary>
        /// <value>The route.</value>
        [ForeignKey(nameof(RouteId))]
        public Route Route { get; set; }

        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>The time.</value>
        public TimeSpan Time { get; set; }
    }
}