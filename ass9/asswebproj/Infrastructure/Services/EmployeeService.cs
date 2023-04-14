using ApplicationCore.Entities;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class EmployeeService : IEmployeeService
    {
        EmployeeRepository epr ;
        public EmployeeService()
        {
            epr = new EmployeeRepository();
        }
        public void AddEmployee()
        {
            Employees e = new Employees();
            Console.Write("first name of new employee: ");
            e.FirstName = Console.ReadLine();
            Console.Write("last name of new employee: ");
            e.LastName = Console.ReadLine();
            Console.Write("Salary: ");
            e.Salary = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Department id: ");
            e.DeptId = Convert.ToInt32(Console.ReadLine());
            if (epr.Insert(e)>0)
            {
                Console.WriteLine("Successfully Inserted");
            }
            else
            {
                Console.WriteLine("Insertion failed");
            }
        }

        public void DeleteEmployee()
        {
            Console.Write("Enter Id number to Delete: ");
            int id = Convert.ToInt32(Console.ReadLine());
            epr.DeleteById(id);
        }

        public void GetAllEmployees()
        {
            IEnumerable<Employees> Employees = epr.GetAll();
            foreach (var e in Employees)
            {
                Console.WriteLine($"{e.Id} \t {e.FirstName} \t {e.LastName} \t {e.Salary} \t {e.DeptId}");
            }
        }

        public Employees GetEmployeeById()
        {
            Console.Write("Enter Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Employees e = epr.GetById(id);
            Console.WriteLine($"{e.Id} \t {e.FirstName} \t {e.LastName} \t {e.Salary} \t {e.DeptId}");
            return e;
        }

        public void UpdateEmployee()
        {
            Employees e = GetEmployeeById();
            Console.Write("new first name of employee: ");
            e.FirstName = Console.ReadLine();
            Console.Write("new last name of employee: ");
            e.LastName = Console.ReadLine();
            Console.Write("new Salary: ");
            e.Salary = Convert.ToDecimal(Console.ReadLine());
            Console.Write("new Department id: ");
            e.DeptId = Convert.ToInt32(Console.ReadLine());
            epr.Update(e);

        }
    }
}
