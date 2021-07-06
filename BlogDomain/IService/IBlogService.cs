using BlogsData.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogDomain.IService
{
    public interface IBlogService
    {
        Task<List<BlogEntity>> GetAllBlogs();
        Task<List<BlogEntity>> GetBlogsUnderCategory(int id);

    }
}