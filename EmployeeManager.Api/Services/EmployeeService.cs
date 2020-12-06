using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManager.Api.Models;

namespace EmployeeManager.Api.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IMongoCollection<Employee> _employees;
        
        public EmployeeService(IDbSettings dbSettings, MongoClient mongoClient)
        {
            _mongoClient = mongoClient;
            var dataBase= _mongoClient.GetDatabase(dbSettings.ConnectionString);
            _employees = dataBase.GetCollection<Employee>("Employees");

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
