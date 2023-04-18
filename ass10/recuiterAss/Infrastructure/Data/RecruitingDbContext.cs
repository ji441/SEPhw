using AppCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class RecruitingDbContext : DbContext
    {
        public RecruitingDbContext(DbContextOptions<RecruitingDbContext> option) : base(option)
        {
            
        }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<JobRequirement> JobRequirements { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<EmployeeRequirementType> EmployeeRequirementTypes { get; set; }
        public DbSet<Submission> Submissions { get; set; }
    }
}
