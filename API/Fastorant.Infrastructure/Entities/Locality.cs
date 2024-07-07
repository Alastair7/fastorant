using System.ComponentModel.DataAnnotations.Schema;

namespace Fastorant.Infrastructure.Entities;

public class Locality : BaseEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long ProvinceId { get; set; }

    // Relationships
    public required Province Province { get; set; }
}