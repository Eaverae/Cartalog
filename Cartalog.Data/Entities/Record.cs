using System.ComponentModel.DataAnnotations.Schema;

namespace Cartalog.Data.Entities
{
    public class Record : EntityBase
    {
        public Guid TuneId { get; set; }

        [ForeignKey(nameof(TuneId))]
        public Tune Tune { get; set; }

        public Guid RouteId { get; set; }

        [ForeignKey(nameof(RouteId))]
        public Route Route { get; set; }

        public TimeSpan Time { get; set; }
    }
}