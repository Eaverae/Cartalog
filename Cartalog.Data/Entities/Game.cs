namespace Cartalog.Data.Entities
{
    public class Game : EntityBase
    {
        public string Name { get; set; }

        public ICollection<Car> Cars { get; set; }
        public ICollection<Route> Routes { get; set; }
        public ICollection<Platform> Platforms { get; set; }
        public ICollection<Upgrade> Upgrades { get; set; }
    }
}