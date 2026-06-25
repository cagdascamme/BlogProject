using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogProject.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [MaxLength(100, ErrorMessage = "The username cannot exceed 100 characters")]
        public string UserName { get; set; }

        [DataType(DataType.Date)]
        public DateTime CommentDate { get; set; }

        [Required]
        public string Content { get; set; }

        [ForeignKey("Post")]
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
