using System.ComponentModel.DataAnnotations.Schema;

namespace WebForum.Models
{
    public class Post
    {
        public string? Id { get; set; }
        public string? Title { get; set; }
        public string? content { get; set; }
        public string? ApplicationUserRefId { get; set; }
        [ForeignKey("ApplicationUserRefId")]
        public ApplicationUser? ApplicationUser { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}