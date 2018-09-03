using BusinessLogicLayer;
using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class ServiceEmployees : IServiceEmployees
    {
        private static IBLEmployees blHandler;

        public ServiceEmployees()
        {
            blHandler = Program.blHandler;
        }

        public void AddEmployee(Employee emp)
        {
            blHandler.AddEmployee(emp);

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
            Debug.WriteLine("test print in ServiceEmployee::GetAllEmployees");
            if (blHandler!= null)
            {
                List<Employee> listEmp = new List<Employee>();
                listEmp = Program.blHandler.GetAllEmployees();
                Debug.WriteLine(listEmp.Count);
                foreach(Employee emp in listEmp)
                {
                    if(emp.Name != "")
                        Debug.WriteLine(emp.Name);
                }
                return null;
            }
            else
            {
                Debug.WriteLine("es null");
                List<Employee> ret = new List<Employee>();
                Employee emp = new FullTimeEmployee() { Name = "blHandler Vacio" };
                ret.Add(emp);
                return ret;
            }
        }

        public Employee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public double CalcPartTimeEmployeeSalary(int idEmployee, int hours)
        {
            throw new NotImplementedException();
        }
    }
}
