using System.ComponentModel.DataAnnotations;

namespace zigit.Models
{
    public class Project
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public byte Score { get; set; }
        [Required]
        public byte DurationInDays { get; set; }
        [Required]
        public int BugsCount { get; set; }
        [Required]
        public bool MadeDadeline { get; set; }
    }
}
