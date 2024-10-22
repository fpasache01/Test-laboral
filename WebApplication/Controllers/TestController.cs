using Microsoft.AspNetCore.Mvc;
using Vass.Domain;


namespace WebApplication.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    private ITestService testService;

    public TestController(ITestService testService)
    {
        this.testService = testService;
    }

    [HttpGet(Name = "GetTest")]
    public async Task<IActionResult> Get()
    {
        return Ok(testService.Get());
    }
}
