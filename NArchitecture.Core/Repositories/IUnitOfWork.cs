using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NArchitecture.Core.Repositories
{
    public interface IUnitOfWork:IDisposable
    {
        IProductRepository Products { get; } //access
        int Complate();
    }
}
