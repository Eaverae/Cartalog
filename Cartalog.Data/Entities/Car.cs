using System.ComponentModel.DataAnnotations.Schema;

namespace Cartalog.Data.Entities
{
    public class Car : EntityBase
    {
        public Guid BrandId { get; set; }

        [ForeignKey(nameof(BrandId))]
        public Brand Brand { get; set; }

        public string TypeName { get; set; }
        public int Year { get; set; }
    }
}