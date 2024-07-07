namespace Fastorant.Infrastructure.Entities;

public class Province : BaseEntity 
{
    public ICollection<Locality>? Localities { get; set; }
}