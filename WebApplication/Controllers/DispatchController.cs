using Domain.Entities;
using Domain.Interfaces;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Vass.Domain;


namespace WebApplication.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DispatchController : ControllerBase
{
    private readonly IFiscalizationService fiscalizationService;
    public DispatchController(IFiscalizationService fiscalizationService)
    {
        this.fiscalizationService = fiscalizationService;
    }

    [HttpPost(Name = "Fiscalization")]
    public async Task<IActionResult> Fiscalization([FromBody]Fiscalization fiscalization)
    {
        fiscalizationService.StartFiscalization(fiscalization);
        return Ok("");
    }
}
