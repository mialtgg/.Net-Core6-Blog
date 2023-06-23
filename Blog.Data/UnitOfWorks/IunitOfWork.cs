using Blog.Core.Entities;
using Blog.dATA.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.dATA.Repositories.Abstractions;
using Blog.Entity.Entities;

namespace Blog.dATA.UnitOfWorks
{
    public interface IunitOfWork:IAsyncDisposable
    {
        IRepository<T> GetRepository<T> () class, IentityBase,new();                                                                        itory<T>() where T : class, IEntityBase, new();
        Task<int> SaveAsync();
        int Save();

    }
}
