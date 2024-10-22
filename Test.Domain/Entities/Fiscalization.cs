using System;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Fiscalization
    {
        public DispatchDocuments dispatchDocuments {get;set;}
        public List<Package> packages {get;set;}
    }
}
