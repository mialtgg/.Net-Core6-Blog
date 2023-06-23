using Blog.dATA.Context;
using Blog.dATA.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.dATA.UnitOfWorks
{
    public class UnitOfWork : IunitOfWork
    {
        private readonly AppDbContext dbContext;
        public UnitOfWork(AppDbContext dbContext) {
            this.dbContext = dbContext;
        }
        public async ValueTask DisposeAsync()
        {
            await dbContext.DisposeAsync();
        }

        public IRepository<T> IunitOfWork.GetRepository<T>()
        {
            return new Repository<T>(dbContext);
        }

        public int Save()
        {
             return dbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await dbContext.SaveChangesAsync();
        }
    }
}
