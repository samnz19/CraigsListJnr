using System.Collections.Generic;

namespace CraigsListJnr.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Post> Ads { get; set; } 
    }
}