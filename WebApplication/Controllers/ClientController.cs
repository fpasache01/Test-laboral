using Domain.Entities;
using Domain.Interfaces;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Vass.Domain;

namespace Namespace
{
    /// <summary>
    /// 
    /// </summary>[ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository clientRepository;
        public ClientController(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        [HttpGet]
        [Route("GetAllClientsEF")]
        public async Task<object> GetAllClients([FromQuery]int pageSize,[FromQuery] int pageNumber)
        {
            return await clientRepository.GetAllClients(pageSize,pageNumber);
        }

        [HttpGet]
        [Route("GetAllClientsSP")]
        public async Task<object> GetAllClientsSP([FromQuery]int pageSize, [FromQuery]int pageNumber)
        {
            return await clientRepository.GetAllClientsBySp(pageSize,pageNumber);
        }
    }
}
