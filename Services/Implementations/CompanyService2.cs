namespace MyFirstMvc.Services.Implementations
{
    public class CompanyService2 : ICompanyService
    {
        public string GetEmployeeName(string companyName, int employeeId)
        {
            return $"Том (Идентификатор: {employeeId}) из {companyName}";
        }
    }
}
