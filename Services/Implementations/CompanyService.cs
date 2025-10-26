namespace MyFirstMvc.Services.Implementations
{
    public class CompanyService : ICompanyService
    {
        public string GetEmployeeName(string companyName, int employeeId)
        {
            return $"Bob (id: {employeeId}) from {companyName}";
        }
    }
}
