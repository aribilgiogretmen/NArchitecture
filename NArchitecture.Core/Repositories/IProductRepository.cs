using NArchitecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NArchitecture.Core.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product>SearchByName(string name);

    }
}
