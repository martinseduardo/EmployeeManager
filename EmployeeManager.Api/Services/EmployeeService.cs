using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManager.Api.Models;

namespace EmployeeManager.Api.Services
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeService(IDbSettings dbSettings)
        {
        }
        public Employee Create(Employee employee)
        {
            throw new NotImplementedException();
        }

        public List<Employee> Read()
        {
            throw new NotImplementedException();
        }

        public Employee Find(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
