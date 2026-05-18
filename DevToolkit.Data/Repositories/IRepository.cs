using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Data.Repositories
{
    public interface IRepository<T>
    {
        T GetById(int id);

        List<T> GetAll();

        bool Insert(T entity);

        bool Update(T entity);

        bool Delete(int id);
    }
}
