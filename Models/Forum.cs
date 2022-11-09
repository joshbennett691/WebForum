namespace WebForum.Models
{
    public class Forum
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int ThreadTotal { get; set; }
        public int MessageTotal { get; set; }
        public ICollection<Thread>? Threads { get; set; }

    }
}
