using System;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;


namespace Domain.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class HandheldDeviceService:IHandleIdDeviceService
    {
        public bool ValidatePackageCount(int receivedCount, int expectedCount)
        {
            Console.WriteLine($"Validating package count: Received {receivedCount}, Expected {expectedCount}");
            return receivedCount == expectedCount;
        }

        public void ConfirmPackageQuantity()
        {
            Console.WriteLine("Package count confirmed via Handheld.");
            // Logic for confirming the package count
        }

        public void RemoveExtraPackages(List<Package> packages, int excessCount)
        {
            Console.WriteLine($"Removing {excessCount} extra packages...");
            // Logic for removing extra packages
        }

        public void SearchForMissingPackages(List<Package> packages, int missingCount)
        {
            Console.WriteLine($"Searching for {missingCount} missing packages...");
            // Logic for searching missing packages
        }

        public void RecordDiscrepancy()
        {
            Console.WriteLine("Recording discrepancy due to unresolved mismatch.");
            // Logic for recording the discrepancy
        }
    }


}
