using System;
using System.Collections.Generic;
using System.Net.Http;
using EmployeeManager.Api.Models;
using EmployeeManager.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;

namespace EmployeeManager.Api.Controllers
{
    [Route("[Controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(IEmployeeService employeeService, ILogger<EmployeeController> logger)
        {
            _employeeService = employeeService;
            _logger = logger;
        }

        [HttpGet("/{id}")]
        public IActionResult FindEmployee(Guid id)
        {
            try
            {
                var employee = _employeeService.Find(id);
                return new ObjectResult(employee);
            }
            catch (HttpRequestException e)
            {
                _logger.LogError(e, $"Item not found. {e}");
                return new StatusCodeResult(404);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Internal error. {e}");
                return new StatusCodeResult(500);
            }
        }

        [HttpGet("")]
        public IActionResult ListEmployee()
        {
            try
            {
                var list = _employeeService.Read();
                return new ObjectResult(list);
            }
            catch (HttpRequestException e)
            {
                _logger.LogError(e, $"Fail to find itens. {e}");
                return new StatusCodeResult(404);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Internal error. {e}");
                return new StatusCodeResult(500);
            }
        }

        [HttpPost("")]
        public IActionResult CreateEmployee([FromBody]Employee employee)
        {
            try
            {
                _employeeService.Create(employee);
                return new StatusCodeResult(201);
            }
            catch (HttpRequestException e)
            {
                _logger.LogError(e, $"Fail to create item. {e}");
                return new StatusCodeResult(404);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Internal error. {e}");
                return new StatusCodeResult(500);
            }
        }

        [HttpPut("")]
        public IActionResult UpdateEmployee(Employee employee)
        {
            try
            {
                _employeeService.Update(employee);
                return new StatusCodeResult(200);
            }
            catch (HttpRequestException e)
            {
                _logger.LogError(e, $"Employee not found. {e}");
                return new StatusCodeResult(404);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Internal error. {e}");
                return new StatusCodeResult(500);
            }
        }

        [HttpDelete("/{id}")]
        public IActionResult RemoveEmployee(Guid id)
        {
            try
            {
                _employeeService.Delete(id);
                return new StatusCodeResult(200);
            }
            catch (HttpRequestException e)
            {
                _logger.LogError(e, $"Employee not found. {e}");
                return new StatusCodeResult(404);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Internal error. {e}");
                return new StatusCodeResult(500);
            }
        }
    }
}