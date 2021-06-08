using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;
using Data;
using Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Repository;
using Data.Interfaces;

namespace MyShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : Controller
    {
        protected IRepository<Category> repository;
        public CategoryController(DbContext context)
        {
            this.repository = new Repository<Category>(context);
        }

        [HttpGet]
        public IEnumerable <Category> Get()
        {
            return repository.Get().ToList();

        }
       
    }
}
