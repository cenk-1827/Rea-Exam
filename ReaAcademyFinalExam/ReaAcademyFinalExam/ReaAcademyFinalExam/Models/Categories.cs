using System.ComponentModel.DataAnnotations;

namespace ReaAcademyFinalExam.Models
{
    public class Categories
    {
        [Key]
        public int categoryID { get; set; }
        public string categoryName { get; set; }
    }
}
