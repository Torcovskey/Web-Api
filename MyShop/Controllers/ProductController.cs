using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data.Entity;
using System.Collections.Generic;
using System.Linq;
using Data.Repository;
using Data.Interfaces;

namespace MyShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        protected IRepository<Product> repository;
        public ProductController(DbContext context)
        {
            this.repository = new Repository<Product>(context);
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return repository.Get().ToList();
        }
        [HttpGet("{Id}")]
        public Product GetId(int Id)
        {
            return repository.GetById(Id);
        }
        [HttpPost]
        public void Post(Product entity)
        {
            repository.Add(entity);
            repository.Save();
        }
        [HttpPut]
        public void Put(Product entity)
        {
            repository.Update(entity);
            repository.Save();
        }
        [HttpDelete]
        public void Delete(int Id)
        {
            repository.DeleteById(Id);
            repository.Save();
        }
        [HttpDelete]
        public void Delete(Product entity)
        {
            repository.Delete(entity);
            repository.Save();
        }
    }
}
