using System;
using System.Threading.Tasks;

namespace Vass.Infrastructure
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITestRepository
    {
        Task<object> Get();
    }
}
