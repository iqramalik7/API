using Microsoft.EntityFrameworkCore;
using practiceset.Models;

namespace practiceset.Data
{
    public class Databasestu: DbContext
    {
        internal object students;

        public Databasestu(DbContextOptions<Databasestu> opt) : base(opt)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
