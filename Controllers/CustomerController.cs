using fitwell_mvc.Data;
using fitwell_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace fitwell_mvc.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IRepository<Customer> _repo;
        public CustomerController(IRepository<Customer> repo)
        {
            _repo = repo;
        }

        public ActionResult Customer()
        {
            var customers = _repo.GetAll();
            return View(customers);
        }
    }
}