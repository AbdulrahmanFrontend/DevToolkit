using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Data.Repositories
{
    public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T>
    {
    }
}
