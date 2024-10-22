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
        Task<List<Client>> GetAllClients();
    }
}
