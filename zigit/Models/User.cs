using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace zigit.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        [ForeignKey("ProjectId")]
        public int ProjectId { get; set; }

        public virtual Project Project { get; set; }

    }

    public class UserCred
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
