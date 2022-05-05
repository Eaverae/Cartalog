namespace Cartalog.Data.Entities
{
    /// <summary>
    /// Class Route.
    /// Implements the <see cref="Cartalog.Data.Entities.EntityBase" />
    /// </summary>
    /// <seealso cref="Cartalog.Data.Entities.EntityBase" />
    public class Route : EntityBase
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the surface types.
        /// </summary>
        /// <value>The surface types.</value>
        public ICollection<SurfaceType> SurfaceTypes { get; set; }
    }
}