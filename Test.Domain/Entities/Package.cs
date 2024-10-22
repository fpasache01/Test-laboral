using System;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /// <summary>
    /// 
    /// </summary>
   public class Package
{
    public string Id { get; set; }
    public string Description { get; set; }

    public Package(string id, string description)
    {
        Id = id;
        Description = description;
    }
}

}
