namespace Fastorant.Infrastructure.Entities;

public class Province : BaseEntity 
{
    // Relationships
    public ICollection<Locality>? Localities { get; set; }
}