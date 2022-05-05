using System.ComponentModel.DataAnnotations.Schema;

namespace Cartalog.Data.Entities
{
    /// <summary>
    /// Class Car.
    /// Implements the <see cref="Cartalog.Data.Entities.EntityBase" />
    /// </summary>
    /// <seealso cref="Cartalog.Data.Entities.EntityBase" />
    public class Car : EntityBase
    {
        /// <summary>
        /// Gets or sets the brand identifier.
        /// </summary>
        /// <value>The brand identifier.</value>
        public Guid BrandId { get; set; }

        /// <summary>
        /// Gets or sets the brand.
        /// </summary>
        /// <value>The brand.</value>
        [ForeignKey(nameof(BrandId))]
        public Brand Brand { get; set; }

        /// <summary>
        /// Gets or sets the name of the type.
        /// </summary>
        /// <value>The name of the type.</value>
        public string TypeName { get; set; }
        /// <summary>
        /// Gets or sets the year.
        /// </summary>
        /// <value>The year.</value>
        public int Year { get; set; }
    }
}