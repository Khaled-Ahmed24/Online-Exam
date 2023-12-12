using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Online_Exam1._0.Models
{
    public class Choices
    {
        [Key,Column(Order = 0)]
        [Required]
       // [ForeignKey("Questions")]
        public int Exam_id { get; set; }

        [Key,Column(Order = 1)]
        [Required]
       // [ForeignKey("Questions")]
        public int Question_id { get; set; }

        [Key,Column(Order = 2)]
        [Required]
        public string Choice_text { get; set; }

        public bool Is_correct { get; set; }


        [ForeignKey("Exam_id,Question_id")]
        public virtual Questions Questions { get; set; } = null!;
    }
}
