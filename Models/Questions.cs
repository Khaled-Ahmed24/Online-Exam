using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Exam1._0.Models
{
    public class Questions
    {
        [Key]
        [Required]
        // [ForeignKey("Exam")]
        public int Exam_id { get; set; }

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Question_id { get; set; }

        [Required]
        public string Question_title { get; set; }

        [Required]
        public string Question_type { get; set; }

        [Required]
       // [Range(0, 1)]
        public decimal Points { get; set; }

        public bool Is_required { get; set; }

        public virtual ICollection<Choices> Choices { get; set; } = new List<Choices>();

        public virtual ICollection<Answers> Answers { get; set; } = new List<Answers>();

        [ForeignKey("Exam_id")]
        public virtual Exam Exam { get; set; } = null!;
    }
}
