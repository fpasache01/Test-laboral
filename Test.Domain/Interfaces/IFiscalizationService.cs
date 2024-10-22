using System;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Services;

namespace Domain.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFiscalizationService
    {
        void StartFiscalization(Fiscalization fiscalization);
    }
}
