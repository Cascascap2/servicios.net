﻿using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALEmployeesMock : IDALEmployees
    {
        private List<Employee> employeesRepository = new List<Employee>()
        {
            new PartTimeEmployee(){HourlyRate = 100, Id=1, Name="Pepe"},
            new PartTimeEmployee(){HourlyRate = 150 , Id=2, Name="Roberto"},
            new PartTimeEmployee(){HourlyRate = 200},
            new PartTimeEmployee(){HourlyRate = 250},
            new PartTimeEmployee(){HourlyRate = 300},
            new FullTimeEmployee(){},
            new FullTimeEmployee(){},
            new FullTimeEmployee(){},
            new FullTimeEmployee(){},
            new FullTimeEmployee(){},
        };

        public void AddEmployee(Employee emp)
        {
            employeesRepository.Add(emp);
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(Employee emp)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            return employeesRepository;
        }

        public Employee GetEmployee(int id)
        {
            if(employeesRepository != null)
                foreach(Employee emp in employeesRepository)
                {
                    if (emp.Id == id)
                        return emp;
                }
            return null;
        }
    }
}
