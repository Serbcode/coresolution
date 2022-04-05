using System.Collections;

namespace CoreSolution.Core.Domain
{
    #pragma warning disable CS8618
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }        
        public virtual ICollection<Role> Roles { get; set;}
    }
    #pragma warning restore
}