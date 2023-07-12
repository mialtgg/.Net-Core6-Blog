using Blog.dATA.UnitOfWorks;
using Blog.Entity.Entities;
using Blog.Service.Services.Abstractions;
using System;


namespace Blog.Service.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IunitOfWork unitofWork;

        public ArticleService(IunitOfWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }
        public async Task<List<Article>> GetAllArticlesAsync()
        {
            return await unitofWork.GetRepository<Article>().GetAllAsync();
        }
    }
}
