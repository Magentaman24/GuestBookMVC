using System.ComponentModel.DataAnnotations;

namespace GuestBookMVC.Models
{
    public class Comment
    { 
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public DateTime CommentDate { get; set; } = DateTime.Now;
        public string Body { get; set; }
        public string Email { get; set; }
    }
}
