using System;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IHandleIdDeviceService
    {
        bool ValidatePackageCount(int receivedCount, int expectedCount);
        void ConfirmPackageQuantity();
        void RemoveExtraPackages(List<Package> packages, int excessCount);
        void SearchForMissingPackages(List<Package> packages, int missingCount);
         void RecordDiscrepancy();
    }
}
