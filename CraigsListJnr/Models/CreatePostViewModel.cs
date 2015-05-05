using System.Collections.Generic;

namespace CraigsListJnr.Models
{
    public class CreatePostViewModel
    {
        public Post Post { get; set; }
        public List<Category> Categories { get; set; } 
    }
}