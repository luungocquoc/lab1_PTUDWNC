using TatBlog.Core.Contracts;
namespace TatBlog.Core.entities
{
    public class post
    {
        public int id { get; set; }
        public string title { get; set; }
        public string Shortdescription { get; set; }
        public string description { get; set; }
        public string Meta { get; set; }
        public string UrlSlug { get; set; }
        public string imageUrl { get; set; }
        public int ViewCount { get; set; }
        public bool Published { get; set; }
        public DateTime PostedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }

    }
}