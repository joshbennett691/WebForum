using System.ComponentModel.DataAnnotations.Schema;

namespace WebForum.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int ApplicationUserRefId { get; set; }
        [ForeignKey("ApplicationUserRefId")]
        public ApplicationUser? ApplicationUser { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
