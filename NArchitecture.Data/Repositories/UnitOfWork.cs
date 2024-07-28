using NArchitecture.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NArchitecture.Data.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {

        private readonly ApplicationDbContext _context;
        public IProductRepository Products { get; private set; } 

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Products = new ProductRepository(_context);

        }

        public int Complate()
        {
            return _context.SaveChanges();
        }

        public void Dispose() { 
        
            _context.Dispose();
        
        }

        
    }
}
