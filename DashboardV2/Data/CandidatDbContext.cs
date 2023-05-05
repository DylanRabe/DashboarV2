using DashboardV2.Models;
using Microsoft.EntityFrameworkCore;


namespace DashboardV2.Data
{
    public class CandidatDbContext : DbContext
    {
        //configure le dbcontext pour injection
        public CandidatDbContext(DbContextOptions<CandidatDbContext> options) : base(options)
        {


        }

        public DbSet<Candidat> Candidats { get; set; }
        
    }
}
