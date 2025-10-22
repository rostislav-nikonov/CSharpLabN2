using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorLab
{
    internal class Employee
    {
        private string name;
        private string department;
        private bool manager;
        private Department employeeDepartment;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }

        public bool Manager
        {
            get
            {
                return manager;
            }
            set
            {
                manager = value;
            }
        }

        public Department EmployeeDepartment
        {
            get
            {
                return employeeDepartment;
            }
            set
            {
                employeeDepartment = value;
            }
        }

        public Employee(string name, string department)
        {
            Name = name;
            Department = department;
            Manager = false;
            employeeDepartment = null;
        }

        public Employee(string name, string department, bool manager)
            : this(name, department)
        {
            Manager = manager;
        }

        public Employee[] GetDepartmentEmployees()
        {
            if (employeeDepartment == null)
            {
                return new Employee[0];
            }
            return employeeDepartment.Employees;
        }

        public Employee GetDepartmentManager()
        {
            if (employeeDepartment == null)
            {
                return null;
            }
            return employeeDepartment.Manager;
        }

        public override string ToString()
        {
            if (Manager)
            {
                return name + " начальник отдела " + department;
            }
            else
            {
                string headName = "неизвестен";
                if (employeeDepartment != null && employeeDepartment.Manager != null)
                {
                    headName = employeeDepartment.Manager.Name;
                }
                return name + " работает в отделе " + department + " начальник которого " + headName;
            }
        }
    }

    internal class Department
    {
        private Employee manager;
        private Employee[] employees;

        public Employee Manager
        {
            get
            {
                return manager;
            }
            set
            {
                manager = value;
            }
        }

        public Employee[] Employees
        {
            get
            {
                return employees;
            }
            set
            {
                employees = value;
            }
        }

        public Department(Employee manager, Employee[] employees)
        {
            Manager = manager;
            Employees = employees;

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].EmployeeDepartment = this;
            }
        }

        public void PrintAllEmployees()
        {
            Console.WriteLine();
            Console.WriteLine(" Сотрудники отдела " + Manager.Department + " ");
            for (int i = 0; i < Employees.Length; i++)
            {
                Console.WriteLine(Employees[i]);
            }
        }
    }
}
