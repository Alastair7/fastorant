using Fastorant.Business.Provinces.Models;

namespace Fastorant.Business.Provinces;

public interface IProvinceBusiness
{
    Task<IEnumerable<ProvinceDTO>> GetAll();

    Task<ProvinceDTO?> GetById(long provinceId);
}