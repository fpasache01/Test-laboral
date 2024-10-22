using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Test.Infrastructure.Context;

namespace Namespace
{
    /// <summary>
    /// 
    /// </summary>
    public class ClientRepository:IClientRepository
    {
        private readonly TESTContext _context;
        public ClientRepository(TESTContext context)
        {
            _context = context;
        }
        public async Task<List<Client>> GetAllClients()
        {
            return await _context.Clients.ToListAsync();
        }
    }
}
