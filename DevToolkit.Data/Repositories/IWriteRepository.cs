using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Data.Repositories
{
    public interface IWriteRepository<T>
    {
        int Insert(T entity);
        bool Update(T entity);
        bool Delete(int ID);
    }
}
