using System.ComponentModel.DataAnnotations.Schema;

namespace Cartalog.Data.Entities
{
    public class TuneSetting : EntityBase
    {
        public Guid TuneId { get; set; }
        public Guid SettingId { get; set; }

        [ForeignKey(nameof(SettingId))]
        public Setting Setting { get; set; }
        public string Value { get; set; }
    }
}