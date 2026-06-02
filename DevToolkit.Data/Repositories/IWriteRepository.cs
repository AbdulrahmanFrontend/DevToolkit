using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Data.Repositories
{
    public interface IWriteRepository<T>
    {
        int Insert(T Entity);
        bool Update(T Entity);
        bool Delete(int ID);
    }
}
