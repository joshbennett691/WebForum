using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebForum.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? DisplayName { get; set; }
        public ICollection<Post>? Posts { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? Location { get; set; }
        public int MessageTotal { get; set; }
        public byte[]? Picture { get; set; }
    }
}
