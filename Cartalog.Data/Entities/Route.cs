namespace Cartalog.Data.Entities
{
    public class Route : EntityBase
    {
        public string Name { get; set; }
        public ICollection<SurfaceType> SurfaceTypes { get; set; }
    }
}