using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WalkUniq.DataAccess.Data;
using WalkUniq.DataAccess.Repository.IRepository;
using WalkUniq.Models;

namespace WalkUniq.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {

        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }

     

        public void Update(Product obj)
        {
            var objFromDb=_db.Products.FirstOrDefault(u=>u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Title = objFromDb.Title;
                objFromDb.Company = objFromDb.Company;
                objFromDb.Price = objFromDb.Price;
                objFromDb.Price50 = objFromDb.Price50;
                objFromDb.ListPrice = objFromDb.ListPrice;
                objFromDb.Price100= objFromDb.Price100;
                objFromDb.Description= objFromDb.Description;
                objFromDb.CategoryId= objFromDb.CategoryId;
                if (obj.ImageUrl !=null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
