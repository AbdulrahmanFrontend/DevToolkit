using DevToolkit.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Data.Repositories
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : IBaseEntity, new()
    {
        protected abstract string TableName { get; }

        public abstract List<TEntity> GetAll();

        public abstract TEntity GetByID(int ID);

        public abstract int Insert(TEntity Entity);

        public abstract bool Update(TEntity Entity);

        public abstract bool Delete(int ID);
    }
}
