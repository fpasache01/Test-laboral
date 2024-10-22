using System;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Entities
{
    /// <summary>
    /// 
    /// </summary>
 public class DispatchDocuments
{
    public int ExpectedPackageCount { get; set; }
    public List<Package> Packages { get; set; }

    public DispatchDocuments(int expectedPackageCount, List<Package> packages)
    {
        ExpectedPackageCount = expectedPackageCount;
        Packages = packages;
    }

    public void ReviewDocuments()
    {
        Console.WriteLine("Reviewing dispatch and picking documents...");
        // Logic to review dispatch documents
    }
}

}
