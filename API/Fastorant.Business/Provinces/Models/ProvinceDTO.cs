using Fastorant.Infrastructure.Entities;

namespace Fastorant.Business.Provinces.Models;

public record ProvinceDTO() 
{
    public long Id { get; init; }
    public string Name { get; init; } = string.Empty;

    public static ProvinceDTO From(Province province)
        => new()
        {
            Id = province.Id,
            Name = province.Name,
        };
};