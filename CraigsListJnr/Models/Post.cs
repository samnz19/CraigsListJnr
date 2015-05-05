using System;

namespace CraigsListJnr.Models
{
    public class Post
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Email { get; set; }
        public string Key { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}