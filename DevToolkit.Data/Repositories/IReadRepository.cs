using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Data.Repositories
{
    public interface IReadRepository<T>
    {
        T GetById(int id);
        List<T> GetAll();
    }
}
