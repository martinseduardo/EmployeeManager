using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeManager.Api.Models;

namespace EmployeeManager.Api.Services
{
    public interface IEmployeeService
    {
        public Employee Create(Employee employee);
        public List<Employee> Read();
        public Employee Find(Guid id);
        public void Update(Employee employee);
        public void Delete(Guid id);
    }
}