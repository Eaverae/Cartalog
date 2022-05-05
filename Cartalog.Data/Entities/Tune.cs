using System.ComponentModel.DataAnnotations.Schema;

namespace Cartalog.Data.Entities
{
    public class Tune : EntityBase
    {
        public Guid CarId { get; set; }

        [ForeignKey(nameof(CarId))]
        public Car Car { get; set; }

        public Guid GameId { get; set; }

        [ForeignKey(nameof(GameId))]
        public Game Game { get; set; }

        public Guid? RouteId { get; set; }

        [ForeignKey(nameof(RouteId))]
        public Route Route { get; set; }

        public ICollection<TuneUpgrade> Upgrades { get; set; }
        public ICollection<TuneSetting> Settings { get; set; }
    }
}