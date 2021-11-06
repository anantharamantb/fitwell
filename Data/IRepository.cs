using System.Collections.Generic;

namespace fitwell_mvc.Data
{
    public interface IRepository<T>
    {
         IEnumerable<T> GetAll();
         T GetById(int id);

    }
}