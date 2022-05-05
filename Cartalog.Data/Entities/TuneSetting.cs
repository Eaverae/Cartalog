using System.ComponentModel.DataAnnotations.Schema;

namespace Cartalog.Data.Entities
{
    /// <summary>
    /// Class TuneSetting.
    /// Implements the <see cref="Cartalog.Data.Entities.EntityBase" />
    /// </summary>
    /// <seealso cref="Cartalog.Data.Entities.EntityBase" />
    public class TuneSetting : EntityBase
    {
        /// <summary>
        /// Gets or sets the tune identifier.
        /// </summary>
        /// <value>The tune identifier.</value>
        public Guid TuneId { get; set; }
        /// <summary>
        /// Gets or sets the setting identifier.
        /// </summary>
        /// <value>The setting identifier.</value>
        public Guid SettingId { get; set; }

        /// <summary>
        /// Gets or sets the setting.
        /// </summary>
        /// <value>The setting.</value>
        [ForeignKey(nameof(SettingId))]
        public Setting Setting { get; set; }
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        public string Value { get; set; }
    }
}