using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace _2Blogs.Models.BlogViewModels
{
    public class BlogViewModel
    {
        
        public List<Blog> Blogs { get; set; }
        public List<ApplicationUser> User { get; set; }
        public List<Tag> Tags { get; set; }

        public BlogViewModel(List<ApplicationUser> claimsPrincipal, List<Blog> list, List<Tag> tags)
        {
            this.Tags = tags;
            this.User = claimsPrincipal;
            this.Blogs = list;
        }
    }
}
