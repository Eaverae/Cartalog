using System.ComponentModel.DataAnnotations.Schema;

namespace Cartalog.Data.Entities
{
    public class TuneUpgrade : EntityBase
    {
        public Guid TuneId { get; set; }
        public Guid UpgradeId { get; set; }

        [ForeignKey(nameof(UpgradeId))]
        public Upgrade Upgrade { get; set; }
    }
}