using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2Blogs.Models.PostViewModels
{
    public class ListPostViewModel
    {
        public string BlogID { get; set; }
        public string UserId { get; set; }
        public IEnumerable<Post> Posts { get; set; }
        public ListPostViewModel()
        {
            Posts = new List<Post>();
        }
    }
}
