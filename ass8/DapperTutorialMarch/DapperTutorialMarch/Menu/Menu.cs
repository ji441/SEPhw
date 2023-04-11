using Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorialMarch.Menu
{
    public class MenuSelection
    {
        DepartmentService e;
        
        public MenuSelection() 
        {
            e = new DepartmentService();
        }
        public void Run()
        {
            int choice = this.InputChoice();
            if(choice <=0 || choice>5)
            {
                Console.WriteLine("please give a integer in range [1,5]");
            }
            if(choice == 1)
            {
                e.AddDepartment();
            }
            else if(choice == 2)
            {
                e.DeleteDepartment();
            }
            else if(choice == 3)
            {
                e.GetAllDepartments();
            }
            else if (choice == 4)
            {
                e.UpdateDepartment();
            }
            else
            {
                e.GetDepartmentById();
            }

        }

        public int InputChoice()
        {
            int choice = int.Parse(Console.ReadLine());
            
            return choice;
        }
    }
}
