using System;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Test.Infrastructure.Context;

namespace Namespace
{
    /// <summary>
    /// 
    /// </summary>
    public class ClientRepository : IClientRepository
    {
        private readonly TESTContext _context;
        public ClientRepository(TESTContext context)
        {
            _context = context;
        }
        public async Task<List<Client>> GetAllClients(int pageSize, int pageNumber)
        {
            IQueryable<Client> query = _context.Clients;

            var totalRecords = await query.CountAsync();
            return await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }
        public async Task<List<Client>> GetAllClientsBySp(int pageSize, int pageNumber)
        {
            var pageNumberParam = new SqlParameter("@PageNumber", pageNumber);
            var pageSizeParam = new SqlParameter("@PageSize", pageSize);
            return await _context.Clients.FromSqlRaw("exec GetAllClients @PageNumber,@PageSize", pageNumberParam, pageSizeParam).ToListAsync();
        }
    }
}
