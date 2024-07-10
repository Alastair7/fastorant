using Fastorant.Business.Provinces.Models;
using Fastorant.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Fastorant.Business.Provinces;

public class ProvinceBusiness : IProvinceBusiness
{
    private readonly FastorantContext _fastorantDB;

    public ProvinceBusiness(FastorantContext fastorantDB)
    {
        _fastorantDB = fastorantDB ?? throw new ArgumentException(nameof(fastorantDB));
    }
    public async Task<IEnumerable<ProvinceDTO>> GetAll()
    {
        var provinces = await _fastorantDB.Provinces.ToListAsync();

        var result = provinces.Select(ProvinceDTO.From);

        return result;
    }

    public async Task<ProvinceDTO?> GetById(long provinceId)
    {
        var province = await _fastorantDB.Provinces.FindAsync(provinceId);

        if (province == null) 
        { 
            return null; 
        }

        var result = ProvinceDTO.From(province);

        return result;
    }
}