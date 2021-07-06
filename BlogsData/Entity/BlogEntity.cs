
using BlogsData.Entity;
using System;
using System.Collections.Generic;

namespace BlogsData.Entities
{
    public class BlogEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string RssFeed { get; set; }
        public DateTime TS { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<CategoryEntity> Categories { get; set; }
    }
}
