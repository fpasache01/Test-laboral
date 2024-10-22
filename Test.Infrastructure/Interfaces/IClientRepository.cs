using System;
using System.Threading.Tasks;
using Test.Infrastructure.Context;

namespace Namespace
{
    /// <summary>
    /// 
    /// </summary>
    public interface IClientRepository
    {
        Task<List<Client>> GetAllClients(int pageSize, int pageNumber);
        Task<List<Client>> GetAllClientsBySp(int pageSize,int pageNumber);
    }
}
