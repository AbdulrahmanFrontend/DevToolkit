using DevToolkit.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Data.Repositories
{
    public abstract class BaseRepository<TEntity> where TEntity : BaseEntity, new()
    {
    }
}
