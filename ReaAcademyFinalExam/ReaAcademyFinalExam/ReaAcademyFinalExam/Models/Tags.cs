using System.ComponentModel.DataAnnotations;

namespace ReaAcademyFinalExam.Models
{
    public class Tags
    {
        [Key]
        public int tagID { get; set; }
        public string tagName { get; set; }
    }
}
