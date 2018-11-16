using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2Blogs.Models
{
    public class Blog
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Post> Posts { get; set; }
        public ApplicationUser User { get; set; }
        public Blog()
        {
           
            Posts = new List<Post>();
        }
    }
}
