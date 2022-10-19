using Auvo.ClimaTempo.Business.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auvo.ClimaTempo.Business.Core.Data
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task<List<TEntity>> ObterTodos();
    }
}
