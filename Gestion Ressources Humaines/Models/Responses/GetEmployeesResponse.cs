namespace Gestion_Ressources_Humaines.Models.Responses
{
    public class GetEmployeesResponse : BaseResponse
    {
        public List<Employee>? Employees { get; set; }
    }
}
