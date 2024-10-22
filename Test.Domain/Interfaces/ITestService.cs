using System;
using System.Threading.Tasks;

namespace Vass.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITestService
    {
        Task<object> Get();
    }
}
