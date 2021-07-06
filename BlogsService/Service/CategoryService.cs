using BlogsData.Context;
using BlogsData.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogsService.Service
{
    public class CategoryService : ICategoryService
    {
        private Context context;

        public CategoryService(Context context)
        {
            this.context = context;
        }
        public async Task<List<CategoryEntity>> GetCategories()
        {
            var categories = context.Categories;

            return await categories.ToListAsync();
        }
    }
}