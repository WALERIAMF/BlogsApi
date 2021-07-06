using BlogDomain.Model;
using BlogsData.Entity;
using System.Collections.Generic;

namespace BlogDomain.Helper
{
    public class CategoryHelper
    {
        public static List<CategoryModel> ConvertCategories(List<CategoryEntity> categories)
        {
            var categoryModels = categories.ConvertAll(category => new CategoryModel
            {
                Id = category.Id,
                Name = category.Name,
            });

            return categoryModels;
        }
    }
}