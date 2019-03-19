using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _2Blogs.Models
{
    public class Blog
    {
        public string Id { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        public string Title { get; set; }
        [Required]
        [StringLength(180, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        public string Description { get; set; }
        public List<Post> Posts { get; set; }
        public ApplicationUser User { get; set; }
        public List<Tag> Tags { get; set; }
        public Blog()
        {
           
            Posts = new List<Post>();
        }
    }
}
