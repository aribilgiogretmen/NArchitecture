using NArchitecture.Core.Entities;
using NArchitecture.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NArchitecture.Data.Repositories
{
    public  class ProductRepository:Repository<Product>,IProductRepository
    {

        public ProductRepository(ApplicationDbContext context) : base(context) { 
        
        
        }

        public ApplicationDbContext AppDbContext
        {

            get { return Context as ApplicationDbContext; } 
        }

        public IEnumerable<Product> SearchByName(string name)
        {
            
            return AppDbContext.Product.Where(p=> p.Name.Contains (name)).ToList();
        }
    }
}
