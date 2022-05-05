namespace Cartalog.Data.Entities
{
    /// <summary>
    /// Class Setting.
    /// Implements the <see cref="Cartalog.Data.Entities.EntityBase" />
    /// </summary>
    /// <seealso cref="Cartalog.Data.Entities.EntityBase" />
    public class Setting : EntityBase
    {
        /// <summary>
        /// Gets or sets the game identifier.
        /// </summary>
        /// <value>The game identifier.</value>
        public Guid GameId { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the maximum.
        /// </summary>
        /// <value>The maximum.</value>
        public string Maximum { get; set; }

        /// <summary>
        /// Gets or sets the minimum.
        /// </summary>
        /// <value>The minimum.</value>
        public string Minimum { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
    }
}