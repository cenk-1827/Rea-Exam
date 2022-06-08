using System.ComponentModel.DataAnnotations;

namespace ReaAcademyFinalExam.Models
{
    public class Notes
    {
        [Key]
        public int noteID { get; set; }
        public string noteName { get; set; }
        public string noteContent { get; set; }
        public Categories categories { get; set; }
        public string categoryName { get; set; }
        public Tags tags { get; set; }
        public string tagName { get; set; }
    }
}
