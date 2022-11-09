namespace WebForum.Models
{
    public class ApplicationUser
    {
        public ICollection<Post>? Posts { get; set; }
    }
}
