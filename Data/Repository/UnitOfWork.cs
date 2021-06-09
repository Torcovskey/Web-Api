using Data.Interfaces;
using Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext context;
        private Repository<Account> accountRepository;
        private Repository<Basket> basketRepository;
        private Repository<Category> categoryRepository;
        private Repository<Company> companyRepository;
        private Repository<Order> orderRepository;
        private Repository<Product> productRepository;
        public UnitOfWork (DbContext context)
        {
            this.context = context;
        }

        public Repository<Account> AccountRepository
        {
            get 
            {
                if (this.accountRepository == null)
                {
                    this.accountRepository = new Repository<Account>(context);
                }
                return accountRepository;
            }
        }
        public Repository<Basket> BasketRepository
        {
            get
            {
                if (this.basketRepository == null)
                {
                    this.basketRepository = new Repository<Basket>(context);
                }
                return basketRepository;
            }
        }
        public Repository<Category> CategoryRepository
        {
            get
            {
                if (this.categoryRepository == null)
                {
                    this.categoryRepository = new Repository<Category>(context);
                }
                return categoryRepository;
            }
        }
        public Repository<Company> CompanyRepository
        {
            get
            {
                if (this.companyRepository == null)
                {
                    this.companyRepository = new Repository<Company>(context);
                }
                return companyRepository;
            }
        }
        public Repository<Order> OrderRepository
        {
            get
            {
                if (this.orderRepository == null)
                {
                    this.orderRepository = new Repository<Order>(context);
                }
                return orderRepository;
            }
        }
        public Repository<Product> ProductRepository
        {
            get
            {
                if (this.productRepository == null)
                {
                    this.productRepository = new Repository<Product>(context);
                }
                return productRepository;
            }
        }
        public void Save ()
        {
            context.SaveChanges();
        }
    }
}
