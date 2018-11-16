using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2Blogs.Models.PostViewModels
{
    public class CreatePostViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Blog Blog { get; set; }
        public string BlogId { get; set; }
    }
}
