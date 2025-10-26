using Microsoft.AspNetCore.Mvc;
using MyFirstMvc.Services;

namespace MyFirstMvc.Controllers
{
    public class CompanyController : Controller
    {
        [HttpGet("/company/{companyName}/employees/{employeeId:int}")]
        public IActionResult GetCompanyEmployee(
            [FromRoute] string companyName,
            [FromRoute] int employeeId,
            [FromServices] ICompanyService companyService
        )
        {
            string employeeName = companyService.GetEmployeeName(companyName, employeeId);
            return View("~/Views/Greeting/Index.cshtml", employeeName);
        }
    }
}
