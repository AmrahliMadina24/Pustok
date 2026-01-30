using Pustok.Core.Entites;
using Pustok.DataAccess.Contexts;
using Pustok.DataAccess.Repositories.Abstractions;
using Pustok.DataAccess.Repositories.Implementations.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pustok.DataAccess.Repositories.Implementations
{
    internal class ProductRepository(AppDbContext _context) : Repository<Product>(_context),IProductRepository
    {
    }
}
