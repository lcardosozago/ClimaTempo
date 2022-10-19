using Auvo.ClimaTempo.Business.Core.Data;
using Auvo.ClimaTempo.Business.Core.Models;
using Auvo.ClimaTempo.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auvo.ClimaTempo.Infra.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly AppDbContext Db;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository()
        {
            Db = new AppDbContext();
            DbSet = Db.Set<TEntity>();
        }

        public virtual async Task<List<TEntity>> ObterTodos()
        {
            return await DbSet.ToListAsync();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
