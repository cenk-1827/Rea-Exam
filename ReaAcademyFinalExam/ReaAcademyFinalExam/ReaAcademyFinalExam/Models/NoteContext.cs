using Microsoft.EntityFrameworkCore;

namespace ReaAcademyFinalExam.Models
{
    public class NoteContext :DbContext
    {
        public NoteContext(DbContextOptions<NoteContext> options) : base(options) { }

        public DbSet<Notes> Notes { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Tags> Tags { get; set; }
    }
}
