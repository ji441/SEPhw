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
    public class CandidateRepository : BaseRepository<Candidate>,ICandidateRepository
    {
        public CandidateRepository(RecruitingDbContext context) : base(context) { }
    }
}
