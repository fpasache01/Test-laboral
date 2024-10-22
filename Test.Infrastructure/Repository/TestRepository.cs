using System;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace Vass.Infrastructure
{
    /// <summary>
    /// 
    /// </summary>
    public class TestRepository:ITestRepository
    {
        public async Task<object> Get(){
            return "123";
        }
    }
}
