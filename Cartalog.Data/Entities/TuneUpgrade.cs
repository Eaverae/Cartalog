using System.ComponentModel.DataAnnotations.Schema;

namespace Cartalog.Data.Entities
{
    /// <summary>
    /// Class TuneUpgrade.
    /// Implements the <see cref="Cartalog.Data.Entities.EntityBase" />
    /// </summary>
    /// <seealso cref="Cartalog.Data.Entities.EntityBase" />
    public class TuneUpgrade : EntityBase
    {
        /// <summary>
        /// Gets or sets the tune identifier.
        /// </summary>
        /// <value>The tune identifier.</value>
        public Guid TuneId { get; set; }
        /// <summary>
        /// Gets or sets the upgrade identifier.
        /// </summary>
        /// <value>The upgrade identifier.</value>
        public Guid UpgradeId { get; set; }

        /// <summary>
        /// Gets or sets the upgrade.
        /// </summary>
        /// <value>The upgrade.</value>
        [ForeignKey(nameof(UpgradeId))]
        public Upgrade Upgrade { get; set; }
    }
}