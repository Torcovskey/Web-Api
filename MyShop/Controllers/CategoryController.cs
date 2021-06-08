﻿using Microsoft.AspNetCore.Mvc;
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
    public class CategoryController : Controller
    {
        protected IRepository<Category> repository;
        public CategoryController(DbContext context)
        {
            this.repository = new Repository<Category>(context);
        }

        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return repository.Get().ToList();
        }
        [HttpGet("{Id}")]
        public Category GetId(int Id)
        {
            return repository.GetById(Id);
        }
        [HttpPost]
        public void Post(Category entity)
        {
            repository.Add(entity);
            repository.Save();
        }
        [HttpPut]
        public void Put(Category entity)
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
        public void Delete(Category entity)
        {
            repository.Delete(entity);
            repository.Save();
        }
    }
}
