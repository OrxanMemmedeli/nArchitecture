using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Persistence.Repositories;
using rentACar.Application.Services.Repositories;
using rentACar.Domain.Entities;
using rentACar.Persistance.Contexts;

namespace rentACar.Persistance.Repositories
{
    public class BrandRepository : EfRepositoryBase<Brand, rentACarDbContext>, IBrandRepository
    {
        public BrandRepository(rentACarDbContext context) : base(context)
        {
        }
    }
}
