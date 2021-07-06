using BlogsData.Entities;
using System.Collections.Generic;

namespace BlogsData.Entity
{
    public class CategoryEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<BlogEntity> Blogs { get; set; }
    }
}