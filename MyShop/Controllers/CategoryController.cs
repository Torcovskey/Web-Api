using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Data.Entity;
using System.Collections.Generic;
using System.Linq;
using Data.Repository;
using Data.Interfaces;
using MyShop;
using MyShop.ConvertToApi;
using Data.ApiEntity;

namespace MyShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : Controller
    {
        private UnitOfWork repository;
        public CategoryController(DbContext context)
        {
            this.repository = new UnitOfWork(context);
        }

        [HttpGet]
        public IEnumerable<ApiCategory> Get()
        {
            var categories = repository.CategoryRepository.Get();
            return ConvertToApi.ConvertToApi.Categories(categories);
        }
    }
}
