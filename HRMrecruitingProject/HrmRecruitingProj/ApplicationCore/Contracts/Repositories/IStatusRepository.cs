﻿using Recruiting.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruiting.ApplicationCore.Contracts.Repositories
{
    public interface IStatusRepository : IBaseRepository<Status>
    {
        public Task<IEnumerable<Status>> GetStatusByState(string state);
    }
}
