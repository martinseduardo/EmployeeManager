namespace EmployeeManager.Api.Models
{
    public interface IDbSettings
    {
        public string ConnectionString { get; set; }
        public string DbName { get; set; }
    }
}