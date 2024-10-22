using System;
using System.Threading.Tasks;
using Vass.Infrastructure;

namespace Vass.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class TestService:ITestService
    {
        private readonly ITestRepository testRepository;
        public TestService(ITestRepository testRepository){
            this.testRepository = testRepository;
        }
        public Task<object> Get(){
            return testRepository.Get();
        }
    }
}
