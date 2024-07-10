using Fastorant.Business.Provinces;
using Microsoft.AspNetCore.Mvc;

namespace Fastorant.Host.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProvinceController : ControllerBase
{
    private readonly IProvinceBusiness _provinceBusiness;

    public ProvinceController(IProvinceBusiness provinceBusiness)
    {
        _provinceBusiness = provinceBusiness ?? throw new ArgumentException(nameof(provinceBusiness));
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var provinces = await _provinceBusiness.GetAll();
        return Ok(provinces);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(long id)
    {
        var province = await _provinceBusiness.GetById(id);

        return province == null ? 
            NotFound($"Province with ID: {id} not found") 
            : Ok(province);
    }

    [HttpGet("name/{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
        var province = await _provinceBusiness.GetByName(name);

        return province == null ?
            NotFound($"Province with ID: {name} not found")
            : Ok(province);
    }


}