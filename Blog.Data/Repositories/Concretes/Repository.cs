using Blog.Core.Entities;
using Blog.dATA.Context;
using Blog.dATA.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Blog.dATA.Repositories.Concretes
{
    internal class Repository<T> : IRepository<T> where T : IEntityBase, new()
    {
        //IRepositorye de herhangi bir değer yolladığımda o entitynin soyut halini oluşturabilsin diye 
        //ona da <T> verdik
        private readonly AppDbContext dbContext;

        public Repository(AppDbContext dbContext)

        {
            this.dbContext = dbContext;
        }
         private DbSet<T> Table { get => dbContext.Set<T>(); }


        ///Burada oluşturduğumuz dataseti süreli set etmemek için aşağıdaa bir fonksiyon oluşturduk 
        //böylece tableya addaysnc i atadık ve bu bize bu işlemi yaptık

        public async Task<List<T>> GetAllAsync(Expression<Func<T,bool>>predicate=null,params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Table;
            if (predicate != null)
                query = query.Where(predicate);
            if (includeProperties.Any()) //include properties içinde herhangi bir tane varsa demek 
                foreach (var item in includeProperties)
                    query = query.Include(item);
            return await query.ToListAsync();    
        }
        public async Task AddAsync (T entity)
        { 
            await Table.AddAsync(entity);
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate , params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Table;
            query = query.Where(predicate);
            if (includeProperties.Any()) //include properties içinde herhangi bir tane varsa demek 
                foreach (var item in includeProperties)
                    query = query.Include(item);
            return await query.SingleAsync();
        }

        public async Task<T> GetByGuidAsync(Guid id)
        {
            return await Table.FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)

        {
                await Task.Run(() => Table.Update(entity));
                return entity;

        }

        public async Task<T> DelateAsync(T entity)
        {
            await Task.Run(() => Table.Remove(entity));
            return entity;
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return await Table.AnyAsync(predicate);  
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> predicate = null)
        {
            return await Table.CountAsync(predicate) ;
        }
    }
}
//Taskın bu kısımdaki karşılığı voiddir