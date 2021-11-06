using System.Collections.Generic;
using System.Linq;
using fitwell_mvc.Models;

namespace fitwell_mvc.Data
{
    public class CustomerRepository : IRepository<Customer>
    {
        private readonly AppDbContext _context;
        public CustomerRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public Customer GetById(int id)
        {
            return _context.Customers.Find(id);
        }
    }
}