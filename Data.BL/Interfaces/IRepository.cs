using Data.DL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.BL.Interfaces
{
    public interface IRepository<Tentity> where Tentity : BaseEntitiy
    {
        Task<ICollection<Tentity>> GetAllAsync();
        Task<Tentity> GetByIdAsync(int id);
        Task AddAsync(Tentity entity);
        void Delete(Tentity entity);
        void Update(Tentity entity);
        IEnumerable<Tentity> Filter(Func<Tentity, bool> predicate);
        IEnumerable<TResult> Select<TResult>(Func<Tentity, TResult> selector);
        Task<IEnumerable<Tentity>> GetAllWithInclude(params string[] includes);
    }
}
