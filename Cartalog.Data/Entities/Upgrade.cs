namespace Cartalog.Data.Entities
{
    public class Upgrade : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid GameId { get; set; }
    }
}