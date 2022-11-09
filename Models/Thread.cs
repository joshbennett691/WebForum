using System.ComponentModel.DataAnnotations.Schema;

namespace WebForum.Models
{
    public class Thread
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Replies { get; set; }
        public int Views { get; set; }
        public int ForumRefId { get; set; }
        [ForeignKey("ForumRefId")]
        public Forum? Forum { get; set; }

    }
}
