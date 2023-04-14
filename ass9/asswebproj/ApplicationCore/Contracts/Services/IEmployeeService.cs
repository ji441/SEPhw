﻿using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public interface IEmployeeService
    {
        void AddEmployee();
        void DeleteEmployee();
        void GetAllEmployees();
        Employees GetEmployeeById();
        void UpdateEmployee();
    }
}
