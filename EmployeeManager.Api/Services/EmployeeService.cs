using System;
using System.Collections.Generic;
using EmployeeManager.Api.Models;
using MongoDB.Driver;

namespace EmployeeManager.Api.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IMongoCollection<Employee> _employees;

        public EmployeeService(IDbSettings dbSettings)
        {
            var mongoClient = new MongoClient(dbSettings.ConnectionString);
            var dataBase = mongoClient.GetDatabase(dbSettings.DbName);
            _employees = dataBase.GetCollection<Employee>("Employees");

        }
        public Employee Create(Employee employee)
        {
            _employees.InsertOne(employee);
            return employee;
        }

        public List<Employee> Read() =>
            _employees.Find(x => true).ToList();

        public Employee Find(Guid id) =>
            _employees.Find(x => x.Id == id).FirstOrDefault();

        public void Update(Employee employee) =>
            _employees.ReplaceOne(x => x.Id == employee.Id, employee);

        public void Delete(Guid id) =>
            _employees.DeleteOne(x => x.Id == id);
    }
}
