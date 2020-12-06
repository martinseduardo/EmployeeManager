using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManager.Api.Models
{
    public class DbSettings : IDbSettings
    {
        public string ConnectionString { get; set; }
        public string DbName { get; set; }
    }
}
