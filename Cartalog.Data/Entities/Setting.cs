namespace Cartalog.Data.Entities
{
    public class Setting : EntityBase
    {
        public Guid GameId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Minimum { get; set; }
        public string Maximum { get; set; }
    }
}