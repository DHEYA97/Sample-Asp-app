using Data.BL.Interfaces;
using Data.DL.Data;
using Data.DL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.BL.Services
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntitiy
    {
        private readonly ApplicationDbContext context;
        public Repository(ApplicationDbContext _context)
        {
            context = _context;
        }
        public async Task AddAsync(TEntity entity)
        {
            await context.Set<TEntity>().AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            entity.IsDeleted = !entity.IsDeleted;
        }

        public async Task<ICollection<TEntity>> GetAllAsync()
        {
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }
        public void Update(TEntity entity)
        {
            context.Set<TEntity>().Update(entity);
        }
        public IEnumerable<TEntity> Filter(Func<TEntity, bool> predicate)
        {
            return context.Set<TEntity>().Where(predicate).ToList();
        }

        public IEnumerable<TResult> Select<TResult>(Func<TEntity, TResult> selector)
        {
            return context.Set<TEntity>().Select(selector).ToList();
        }
        public async Task<IEnumerable<TEntity>> GetAllWithInclude(params string[] includes)
        {
            IQueryable<TEntity> query = context.Set<TEntity>();
            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return await query.ToListAsync();
        }

    }
}
