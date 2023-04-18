using AppCore.Contracts.Repositories;
using AppCore.Entities;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class JobCategoryRepository : BaseRepository<JobCategory>, IJobCategoryRepository
    {
        public JobCategoryRepository(RecruitingDbContext context) : base(context) { }
    }
}
