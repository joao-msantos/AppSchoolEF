using Microsoft.EntityFrameworkCore;
using AppSchoolEF.Models;

namespace AppSchoolEF.Data
{
    public class SchoolsContext : DbContext
    {
        public SchoolsContext(DbContextOptions<SchoolsContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
