using Fastorant.Common.Enums;

namespace Fastorant.Infrastructure.Entities;

public class Business : BaseEntity
{
    public long ProvinceID { get; set; }
    public long LocalityID { get; set; }
    public BusinessTypes Type { get; set; } = BusinessTypes.Unknown;
    public string MorningSchedule { get; set; } = string.Empty;
    public string AfternoonSchedule { get; set; } = string.Empty;
    public string WorkingDays{ get; set; } = string.Empty;
    public double CoordinateX { get; set; }
    public double CoordinateY { get; set; }

    // Relationships
    public required Province Province { get; set; }
    public required Locality Locality { get; set; }
}