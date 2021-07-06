using BlogDomain.IService;
using BlogsData.Context;
using BlogsData.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogsService.Service
{
    public class BlogService : IBlogService
    {
        private readonly Context context;
        public BlogService(Context context)
        {
            this.context = context;
        }


        public async Task<List<BlogEntity>> GetAllBlogs()
        {
            var blogs = context.Blogs.Include(o => o.Categories).Where(o => o.Active).OrderByDescending(o => o.TS);
            return await blogs.ToListAsync();
        }

        public async Task<List<BlogEntity>> GetBlogsUnderCategory(int id)
        {
            var blogs = context.Blogs.Include(o => o.Categories).Where(o => o.Active && o.Categories.Any(category => category.Id == id));
            return await blogs.ToListAsync();
        }
    }
}