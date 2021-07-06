
using BlogsData.Context;
using BlogsData.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogsService.Service
{

    public interface ICategoryService
    {
        Task<List<CategoryEntity>> GetCategories();

    }
}